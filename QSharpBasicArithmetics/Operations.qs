namespace Quantum.QSharpBasicArithmetics
{
    open Microsoft.Quantum.Intrinsic;
    open Microsoft.Quantum.Math;
    open Microsoft.Quantum.Measurement;

    //
    // Implement : |x⟩ |y⟩ -> |x⟩ |x + y mod N⟩ where N = 2^Length(x) = 2^Length(y)
    // with Drapper algorithm (See https://arxiv.org/pdf/1411.5949.pdf)
    //
    operation QuantumAdd (x : Qubit[], y : Qubit[]) : Unit is Adj + Ctl {
        let n = Length(x);
        QFTImpl(y);
        for (i in 0 .. n - 1) {
            for (j in 0 .. (n - 1) - i) {
                Controlled R1Frac([x[i + j]], (2, j + 1, (y)[(n - 1) - i]));
            }
        }
        Adjoint QFTImpl(y);
    }

    operation TestQuantumAdd (a : Int, b : Int, n : Int) : Int {
        mutable resultArray = new Result[n];

        using((x, y) = (Qubit[n], Qubit[n])) {
            // create qubit's array from integer a (ex: 3 -> |011⟩)
            mutable array1 = new Bool[n];
            mutable tempInt1 = a;
            for (idxBit in 0 .. n - 1) {
                set array1 w/= ((n - 1) - idxBit) <- tempInt1 % 2 == 0 ? false | true;
                set tempInt1 = tempInt1 / 2;
            }
            for (idx in 0 .. n - 1) {
                if(array1[idx]) {
                    X(x[idx]);
                }
            }

            // create qubit's array from integer b (ex: 3 -> |011⟩)
            mutable array2 = new Bool[n];
            mutable tempInt2 = b;
            for (idxBit in 0 .. n - 1) {
                set array2 w/= ((n - 1) - idxBit) <- tempInt2 % 2 == 0 ? false | true;
                set tempInt2 = tempInt2 / 2;
            }
            for (idx in 0 .. n - 1) {
                if(array2[idx]) {
                    X(y[idx]);
                }
            }

            // apply Drapper adder
            QuantumAdd(x, y);

            // measure and reset
            for (idx in 0 .. n - 1) {
                set resultArray w/= idx <- MResetZ(y[idx]);
            }
            for (idx in 0 .. n - 1) {
                Reset(x[idx]);
            }
        }

        // get integer's result from measured array (ex : |011⟩ -> 3)
        let resultBool = Microsoft.Quantum.Convert.ResultArrayAsBoolArray(resultArray);
        mutable resultInt = 0;
        for (idx in 0 .. n - 1) {
            if(resultBool[idx]) {
                set resultInt = resultInt + (2 ^ ((n - 1) - idx));
            }
        }
        return resultInt;
    }

    operation TestQuantumSub (a : Int, b : Int, n : Int) : Int {
        mutable resultArray = new Result[n];

        using((x, y) = (Qubit[n], Qubit[n])) {
            // create qubit's array from integer a (ex: 3 -> |011⟩)
            mutable array1 = new Bool[n];
            mutable tempInt1 = a;
            for (idxBit in 0 .. n - 1) {
                set array1 w/= ((n - 1) - idxBit) <- tempInt1 % 2 == 0 ? false | true;
                set tempInt1 = tempInt1 / 2;
            }
            for (idx in 0 .. n - 1) {
                if(array1[idx]) {
                    X(x[idx]);
                }
            }

            // create qubit's array from integer b (ex: 3 -> |011⟩)
            mutable array2 = new Bool[n];
            mutable tempInt2 = b;
            for (idxBit in 0 .. n - 1) {
                set array2 w/= ((n - 1) - idxBit) <- tempInt2 % 2 == 0 ? false | true;
                set tempInt2 = tempInt2 / 2;
            }
            for (idx in 0 .. n - 1) {
                if(array2[idx]) {
                    X(y[idx]);
                }
            }

            // apply Drapper adder
            Adjoint QuantumAdd(x, y);

            // measure and reset
            for (idx in 0 .. n - 1) {
                set resultArray w/= idx <- MResetZ(y[idx]);
            }
            for (idx in 0 .. n - 1) {
                Reset(x[idx]);
            }
        }

        // get integer's result from measured array (ex : |011⟩ -> 3)
        let resultBool = Microsoft.Quantum.Convert.ResultArrayAsBoolArray(resultArray);
        mutable resultInt = 0;
        for (idx in 0 .. n - 1) {
            if(resultBool[idx]) {
                set resultInt = resultInt + (2 ^ ((n - 1) - idx));
            }
        }
        return resultInt;
    }

    //
    // Implement : |x⟩ -> |x + b mod N⟩ for some integer b
    //
    operation QuantumAddByNumber (x : Qubit[], b : Int) : Unit is Adj + Ctl {
        let n = Length(x);

        // apply Draper adder for numeric
        QFTImpl(x);
        for (i in 0 .. n - 1) {
            for (j in 0 .. (n - 1) - i) {
                if(not((b / 2^((n - 1) - (i + j))) % 2 == 0)) {
                    R1Frac(2, j + 1, (x)[(n - 1) - i]);
                }
            }
        }
        Adjoint QFTImpl(x);
    }

    operation TestQuantumAddByNumber (a : Int, b : Int, n : Int) : Int {
        mutable resultArray = new Result[n];

        using(x = Qubit[n]) {
            // create qubit's array from integer a (ex: 3 -> |011⟩)
            mutable array1 = new Bool[n];
            mutable tempInt1 = a;
            for (idxBit in 0 .. n - 1) {
                set array1 w/= ((n - 1) - idxBit) <- tempInt1 % 2 == 0 ? false | true;
                set tempInt1 = tempInt1 / 2;
            }
            for (idx in 0 .. n - 1) {
                if(array1[idx]) {
                    X(x[idx]);
                }
            }

            // apply Draper adder for numeric
            QuantumAddByNumber(x, b);

            // measure and reset
            for (idx in 0 .. n - 1) {
                set resultArray w/= idx <- MResetZ(x[idx]);
            }
        }

        // get integer's result from measured array (ex : |011⟩ -> 3)
        let resultBool = Microsoft.Quantum.Convert.ResultArrayAsBoolArray(resultArray);
        mutable resultInt = 0;
        for (idx in 0 .. n - 1) {
            if(resultBool[idx]) {
                set resultInt = resultInt + (2 ^ ((n - 1) - idx));
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
    operation QuantumMultiply (a : Int, y : Qubit[]) : Unit is Adj + Ctl {
        let n = Length(y);
        let a_mod = a % (2^n);

        using (s = Qubit[n]) {
            // start |y⟩ |0⟩

            // apply adder by repeating "a" (integer) times
            for(r in 0 .. a_mod - 1) {
                QuantumAdd(y, s);
            }
            // now |y⟩ |a y mod N⟩

            // swap first register and second one by tuple
            Microsoft.Quantum.Canon.ApplyToEachCA(SWAP, Microsoft.Quantum.Arrays.Zip(y, s));
            // now |a y mod N⟩ |y⟩

            // reset all s qubits !
            // but it's tricky because we cannot use "Reset()" since here is controlled operator.
            let a_inv = InverseModI(a_mod, 2^n);
            for(r in 0 .. a_inv - 1) {
                Adjoint QuantumAdd(y, s);
            }
        }
    }

    operation TestQuantumMultiply (a : Int, b : Int, n : Int) : Int {
        mutable resultArray = new Result[n];

        using(y = Qubit[n]) {
            // create qubit's array from integer b (ex: 3 -> |011⟩)
            mutable array2 = new Bool[n];
            mutable tempInt2 = b;
            for (idxBit in 0 .. n - 1) {
                set array2 w/= ((n - 1) - idxBit) <- tempInt2 % 2 == 0 ? false | true;
                set tempInt2 = tempInt2 / 2;
            }
            for (idx in 0 .. n - 1) {
                if(array2[idx]) {
                    X(y[idx]);
                }
            }

            // apply multiplier
            QuantumMultiply(a, y);

            // measure and reset
            for (idx in 0 .. n - 1) {
                set resultArray w/= idx <- MResetZ(y[idx]);
            }
        }

        // get integer's result from measured array (ex : |011⟩ -> 3)
        let resultBool = Microsoft.Quantum.Convert.ResultArrayAsBoolArray(resultArray);
        mutable resultInt = 0;
        for (idx in 0 .. n - 1) {
            if(resultBool[idx]) {
                set resultInt = resultInt + (2 ^ ((n - 1) - idx));
            }
        }
        return resultInt;
    }

    //
    // Implement : |x⟩ -> |a^x mod N⟩ for some integer a
    //
    // Important Note :
    // Integer "a" and modulus must be co-prime number.
    // (Because this invokes QuantumMultiply().)
    //
    operation QuantumExponent (a : Int, x : Qubit[]) : Unit {
        let n = Length(x);
        using (s = Qubit[n]) {
            // set |s⟩ = |1⟩
            X(s[n - 1]);

            // apply decomposition elements
            for(idx in 0 .. n - 1) {
                Controlled QuantumMultiply([x[idx]], (a^(2^((n-1) - idx)), s));
            }

            // swap |x⟩ and |s⟩
            Microsoft.Quantum.Canon.ApplyToEachCA(SWAP, Microsoft.Quantum.Arrays.Zip(x, s));

            // Reset s
            for(idx in 0 .. n - 1) {
                Reset(s[idx]);
            }
        }
    }

    operation TestQuantumExponent (a : Int, b : Int, n : Int) : Int {
        mutable resultArray = new Result[n];

        using(x = Qubit[n]) {
            // create qubit's array from integer b (ex: 3 -> |011⟩)
            mutable array2 = new Bool[n];
            mutable tempInt2 = b;
            for (idxBit in 0 .. n - 1) {
                set array2 w/= ((n - 1) - idxBit) <- tempInt2 % 2 == 0 ? false | true;
                set tempInt2 = tempInt2 / 2;
            }
            for (idx in 0 .. n - 1) {
                if(array2[idx]) {
                    X(x[idx]);
                }
            }

            // apply multiplier
            QuantumExponent(a, x);

            // measure and reset
            for (idx in 0 .. n - 1) {
                set resultArray w/= idx <- MResetZ(x[idx]);
            }
        }

        // get integer's result from measured array (ex : |011⟩ -> 3)
        let resultBool = Microsoft.Quantum.Convert.ResultArrayAsBoolArray(resultArray);
        mutable resultInt = 0;
        for (idx in 0 .. n - 1) {
            if(resultBool[idx]) {
                set resultInt = resultInt + (2 ^ ((n - 1) - idx));
            }
        }
        return resultInt;
    }

    //aaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa
    //aaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa
    //aaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa
    //operation QuantumAddByModulus (N : Int, x : Qubit[], y : Qubit[]) : Unit is Adj + Ctl {
        //let n = Length(x);
        //QFTImpl(y);
        //for (i in 0 .. n - 1) {
        //    for (j in 0 .. (n - 1) - i) {
        //        Controlled R1Frac([x[i + j]], (2, j + 1, (y)[(n - 1) - i]));
        //    }
        //}

        //Adjoint QFTImpl(y);
        //using(ancilla = Qubit[0]) {
            // |x⟩ |y⟩ -> |x⟩ |x + y⟩
            //QuantumAdd(x, y);
            // |x⟩ |y⟩ -> |x⟩ |y - N⟩
            //Adjoint QuantumAddByNumber();
        //}
    //}
    //aaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa
    //aaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa
    //aaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa

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
