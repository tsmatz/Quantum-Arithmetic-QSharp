namespace Quantum.QSharpBasicArithmetics
{
    open Microsoft.Quantum.Intrinsic;
    open Microsoft.Quantum.Math;
    open Microsoft.Quantum.Measurement;

    //
    // Implement : |x⟩ |y⟩ -> |x⟩ |x + y mod N⟩ where N = Length(x) = Length(y)
    // with Drapper algorithm (See https://arxiv.org/pdf/1411.5949.pdf)
    //
    operation ModularAdd (x : Qubit[], y : Qubit[]) : Unit is Adj + Ctl {
        let N = Length(x);
        QFTImpl(y);
        for (i in 0 .. N - 1) {
            for (j in 0 .. (N - 1) - i) {
                Controlled R1Frac([x[i + j]], (2, j + 1, (y)[(N - 1) - i]));
            }
        }
        Adjoint QFTImpl(y);
    }

    operation TestModularAdd (a : Int, b : Int, N : Int) : Int {
        mutable resultArray = new Result[N];

        using((x, y) = (Qubit[N], Qubit[N])) {
            // create qubit's array from integer a (ex: 3 -> |011⟩)
            mutable array1 = new Bool[N];
            mutable tempInt1 = a;
            for (idxBit in 0 .. N - 1) {
                set array1 w/= ((N - 1) - idxBit) <- tempInt1 % 2 == 0 ? false | true;
                set tempInt1 = tempInt1 / 2;
            }
            for (idx in 0 .. N - 1) {
                if(array1[idx]) {
                    X(x[idx]);
                }
            }

            // create qubit's array from integer b (ex: 3 -> |011⟩)
            mutable array2 = new Bool[N];
            mutable tempInt2 = b;
            for (idxBit in 0 .. N - 1) {
                set array2 w/= ((N - 1) - idxBit) <- tempInt2 % 2 == 0 ? false | true;
                set tempInt2 = tempInt2 / 2;
            }
            for (idx in 0 .. N - 1) {
                if(array2[idx]) {
                    X(y[idx]);
                }
            }

            // apply Drapper adder
            ModularAdd(x, y);

            // measure and reset
            for (idx in 0 .. N - 1) {
                set resultArray w/= idx <- MResetZ(y[idx]);
            }
            for (idx in 0 .. N - 1) {
                Reset(x[idx]);
            }
        }

        // get integer's result from measured array (ex : |011⟩ -> 3)
        let resultBool = Microsoft.Quantum.Convert.ResultArrayAsBoolArray(resultArray);
        mutable resultInt = 0;
        for (idx in 0 .. N - 1) {
            if(resultBool[idx]) {
                set resultInt = resultInt + (2 ^ ((N - 1) - idx));
            }
        }
        return resultInt;
    }

    operation TestModularSub (a : Int, b : Int, N : Int) : Int {
        mutable resultArray = new Result[N];

        using((x, y) = (Qubit[N], Qubit[N])) {
            // create qubit's array from integer a (ex: 3 -> |011⟩)
            mutable array1 = new Bool[N];
            mutable tempInt1 = a;
            for (idxBit in 0 .. N - 1) {
                set array1 w/= ((N - 1) - idxBit) <- tempInt1 % 2 == 0 ? false | true;
                set tempInt1 = tempInt1 / 2;
            }
            for (idx in 0 .. N - 1) {
                if(array1[idx]) {
                    X(x[idx]);
                }
            }

            // create qubit's array from integer b (ex: 3 -> |011⟩)
            mutable array2 = new Bool[N];
            mutable tempInt2 = b;
            for (idxBit in 0 .. N - 1) {
                set array2 w/= ((N - 1) - idxBit) <- tempInt2 % 2 == 0 ? false | true;
                set tempInt2 = tempInt2 / 2;
            }
            for (idx in 0 .. N - 1) {
                if(array2[idx]) {
                    X(y[idx]);
                }
            }

            // apply Drapper adder
            Adjoint ModularAdd(x, y);

            // measure and reset
            for (idx in 0 .. N - 1) {
                set resultArray w/= idx <- MResetZ(y[idx]);
            }
            for (idx in 0 .. N - 1) {
                Reset(x[idx]);
            }
        }

        // get integer's result from measured array (ex : |011⟩ -> 3)
        let resultBool = Microsoft.Quantum.Convert.ResultArrayAsBoolArray(resultArray);
        mutable resultInt = 0;
        for (idx in 0 .. N - 1) {
            if(resultBool[idx]) {
                set resultInt = resultInt + (2 ^ ((N - 1) - idx));
            }
        }
        return resultInt;
    }

    //
    // Implement : |x⟩ -> |x + b mod N⟩ for some integer b
    //
    operation ModularAddByNumber (x : Qubit[], b : Int) : Unit is Ctl {
        let N = Length(x);

        // create bool array from integer b (ex: 3 -> [F, T, T])
        mutable array2 = new Bool[N];
        mutable tempInt2 = b;
        for (idxBit in 0 .. N - 1) {
            set array2 w/= ((N - 1) - idxBit) <- tempInt2 % 2 == 0 ? false | true;
            set tempInt2 = tempInt2 / 2;
        }

        // apply Draper adder for numeric
        QFTImpl(x);
        for (i in 0 .. N - 1) {
            for (j in 0 .. (N - 1) - i) {
                if(array2[i + j]) {
                    R1Frac(2, j + 1, (x)[(N - 1) - i]);
                }
            }
        }
        Adjoint QFTImpl(x);
    }

    operation TestModularAddByNumber (a : Int, b : Int, N : Int) : Int {
        mutable resultArray = new Result[N];

        using(x = Qubit[N]) {
            // create qubit's array from integer a (ex: 3 -> |011⟩)
            mutable array1 = new Bool[N];
            mutable tempInt1 = a;
            for (idxBit in 0 .. N - 1) {
                set array1 w/= ((N - 1) - idxBit) <- tempInt1 % 2 == 0 ? false | true;
                set tempInt1 = tempInt1 / 2;
            }
            for (idx in 0 .. N - 1) {
                if(array1[idx]) {
                    X(x[idx]);
                }
            }

            // apply Draper adder for numeric
            ModularAddByNumber(x, b);

            // measure and reset
            for (idx in 0 .. N - 1) {
                set resultArray w/= idx <- MResetZ(x[idx]);
            }
        }

        // get integer's result from measured array (ex : |011⟩ -> 3)
        let resultBool = Microsoft.Quantum.Convert.ResultArrayAsBoolArray(resultArray);
        mutable resultInt = 0;
        for (idx in 0 .. N - 1) {
            if(resultBool[idx]) {
                set resultInt = resultInt + (2 ^ ((N - 1) - idx));
            }
        }
        return resultInt;
    }

    //
    // Implement : |y⟩ -> |a y mod N⟩ for some integer a
    //
    // Important Note :
    // Integer "a" and modulus must be co-prime number.
    // (For making this operator must be controlled. Otherwise InverseModI() raises an error.)
    //
    operation ModularMultiply (a : Int, y : Qubit[]) : Unit is Adj + Ctl {
        let N = Length(y);
        using (s = Qubit[N]) {
            // start |y⟩ |0⟩

            // apply adder by repeating "a" (integer) times
            for(r in 0 .. a - 1) {
                ModularAdd(y, s);
            }
            // now |y⟩ |a y mod N⟩

            // swap first register and second one by tuple
            Microsoft.Quantum.Canon.ApplyToEachCA(SWAP, Microsoft.Quantum.Arrays.Zip(y, s));
            // now |a y mod N⟩ |y⟩

            // reset all s qubits !
            // but it's tricky because we cannot use "Reset()" since here is controlled operator.
            let inv_a = InverseModI(a, 2^N);
            for(r in 0 .. inv_a - 1) {
                Adjoint ModularAdd(y, s);
            }
        }
    }

    operation TestModularMultiply (a : Int, b : Int, N : Int) : Int {
        mutable resultArray = new Result[N];

        using(y = Qubit[N]) {
            // create qubit's array from integer b (ex: 3 -> |011⟩)
            mutable array2 = new Bool[N];
            mutable tempInt2 = b;
            for (idxBit in 0 .. N - 1) {
                set array2 w/= ((N - 1) - idxBit) <- tempInt2 % 2 == 0 ? false | true;
                set tempInt2 = tempInt2 / 2;
            }
            for (idx in 0 .. N - 1) {
                if(array2[idx]) {
                    X(y[idx]);
                }
            }

            // apply multiplier
            ModularMultiply(a, y);

            // measure and reset
            for (idx in 0 .. N - 1) {
                set resultArray w/= idx <- MResetZ(y[idx]);
            }
        }

        // get integer's result from measured array (ex : |011⟩ -> 3)
        let resultBool = Microsoft.Quantum.Convert.ResultArrayAsBoolArray(resultArray);
        mutable resultInt = 0;
        for (idx in 0 .. N - 1) {
            if(resultBool[idx]) {
                set resultInt = resultInt + (2 ^ ((N - 1) - idx));
            }
        }
        return resultInt;
    }

    //
    // Implement : |x⟩ -> |a^x mod N⟩ for some integer a
    //
    // Important Note :
    // Integer "a" and modulus must be co-prime number.
    // (Because this invokes ModularMultiply().)
    //
    operation ModularExponent (a : Int, x : Qubit[]) : Unit {
        let N = Length(x);
        using (s = Qubit[N]) {
            // set |s⟩ = |1⟩
            X(s[N - 1]);

            // apply decomposition elements
            for(idx in 0 .. N - 1) {
                //(a^(2^((N-1) - idx))
                Controlled ModularMultiply([x[idx]], (a^(2^((N-1) - idx)), s));
            }

            // swap |x⟩ and |s⟩
            Microsoft.Quantum.Canon.ApplyToEachCA(SWAP, Microsoft.Quantum.Arrays.Zip(x, s));

            // Reset s
            for(idx in 0 .. N - 1) {
                Reset(s[idx]);
            }
        }
    }

    operation TestModularExponent (a : Int, b : Int, N : Int) : Int {
        mutable resultArray = new Result[N];

        using(x = Qubit[N]) {
            // create qubit's array from integer b (ex: 3 -> |011⟩)
            mutable array2 = new Bool[N];
            mutable tempInt2 = b;
            for (idxBit in 0 .. N - 1) {
                set array2 w/= ((N - 1) - idxBit) <- tempInt2 % 2 == 0 ? false | true;
                set tempInt2 = tempInt2 / 2;
            }
            for (idx in 0 .. N - 1) {
                if(array2[idx]) {
                    X(x[idx]);
                }
            }

            // apply multiplier
            ModularExponent(a, x);

            // measure and reset
            for (idx in 0 .. N - 1) {
                set resultArray w/= idx <- MResetZ(x[idx]);
            }
        }

        // get integer's result from measured array (ex : |011⟩ -> 3)
        let resultBool = Microsoft.Quantum.Convert.ResultArrayAsBoolArray(resultArray);
        mutable resultInt = 0;
        for (idx in 0 .. N - 1) {
            if(resultBool[idx]) {
                set resultInt = resultInt + (2 ^ ((N - 1) - idx));
            }
        }
        return resultInt;
    }

    //
    // Implement QFT (Quantum Fourier Transform)
    // see https://tsmatz.wordpress.com/2019/04/26/quantum-computing-qsharp-quantum-fourier-transform-and-phase-estimation/
    // You can also use Microsoft.Quantum.Canon.QFT()
    //
    operation QFTImpl (qs : Qubit[]) : Unit is Adj + Ctl
    {
        body (...)
        {
            let nQubits = Length(qs);
            
            for (i in 0 .. nQubits - 1)
            {
                H(qs[i]);
                for (j in i + 1 .. nQubits - 1)
                {
                    Controlled R1Frac([qs[j]], (1, j - i, qs[i]));
                }
            }
            
            Microsoft.Quantum.Canon.SwapReverseRegister(qs);
        }
    }
}
