#pragma warning disable 1591
using System;
using Microsoft.Quantum.Core;
using Microsoft.Quantum.Intrinsic;
using Microsoft.Quantum.Simulation.Core;

[assembly: CallableDeclaration("{\"Kind\":{\"Case\":\"Operation\"},\"QualifiedName\":{\"Namespace\":\"Quantum.QSharpBasicArithmetics\",\"Name\":\"QuantumAdd\"},\"SourceFile\":\"C:/Demo/Quantum-Arithmetic-QSharp/QSharpBasicArithmetics/Operations.qs\",\"Position\":{\"Item1\":10,\"Item2\":4},\"SymbolRange\":{\"Item1\":{\"Line\":1,\"Column\":11},\"Item2\":{\"Line\":1,\"Column\":21}},\"ArgumentTuple\":{\"Case\":\"QsTuple\",\"Fields\":[[{\"Case\":\"QsTupleItem\",\"Fields\":[{\"VariableName\":{\"Case\":\"ValidName\",\"Fields\":[\"x\"]},\"Type\":{\"Case\":\"ArrayType\",\"Fields\":[{\"Case\":\"Qubit\"}]},\"IsMutable\":false,\"HasLocalQuantumDependency\":false,\"Position\":{\"Case\":\"Null\"},\"Range\":{\"Item1\":{\"Line\":1,\"Column\":23},\"Item2\":{\"Line\":1,\"Column\":24}}}]},{\"Case\":\"QsTupleItem\",\"Fields\":[{\"VariableName\":{\"Case\":\"ValidName\",\"Fields\":[\"y\"]},\"Type\":{\"Case\":\"ArrayType\",\"Fields\":[{\"Case\":\"Qubit\"}]},\"IsMutable\":false,\"HasLocalQuantumDependency\":false,\"Position\":{\"Case\":\"Null\"},\"Range\":{\"Item1\":{\"Line\":1,\"Column\":36},\"Item2\":{\"Line\":1,\"Column\":37}}}]}]]},\"Signature\":{\"TypeParameters\":[],\"ArgumentType\":{\"Case\":\"TupleType\",\"Fields\":[[{\"Case\":\"ArrayType\",\"Fields\":[{\"Case\":\"Qubit\"}]},{\"Case\":\"ArrayType\",\"Fields\":[{\"Case\":\"Qubit\"}]}]]},\"ReturnType\":{\"Case\":\"UnitType\"},\"Information\":{\"Affiliation\":{\"Case\":\"Union\",\"Fields\":[{\"Case\":\"SimpleSet\",\"Fields\":[{\"Case\":\"Adjointable\"}]},{\"Case\":\"SimpleSet\",\"Fields\":[{\"Case\":\"Controllable\"}]}]},\"InferredInformation\":{\"IsSelfAdjoint\":false,\"IsIntrinsic\":false}}},\"Documentation\":[]}")]
[assembly: SpecializationDeclaration("{\"Kind\":{\"Case\":\"QsBody\"},\"TypeArguments\":{\"Case\":\"Null\"},\"Information\":{\"Affiliation\":{\"Case\":\"Union\",\"Fields\":[{\"Case\":\"SimpleSet\",\"Fields\":[{\"Case\":\"Adjointable\"}]},{\"Case\":\"SimpleSet\",\"Fields\":[{\"Case\":\"Controllable\"}]}]},\"InferredInformation\":{\"IsSelfAdjoint\":false,\"IsIntrinsic\":false}},\"Parent\":{\"Namespace\":\"Quantum.QSharpBasicArithmetics\",\"Name\":\"QuantumAdd\"},\"SourceFile\":\"C:/Demo/Quantum-Arithmetic-QSharp/QSharpBasicArithmetics/Operations.qs\",\"Position\":{\"Item1\":10,\"Item2\":4},\"HeaderRange\":{\"Item1\":{\"Line\":1,\"Column\":11},\"Item2\":{\"Line\":1,\"Column\":21}},\"Documentation\":[]}")]
[assembly: SpecializationDeclaration("{\"Kind\":{\"Case\":\"QsAdjoint\"},\"TypeArguments\":{\"Case\":\"Null\"},\"Information\":{\"Affiliation\":{\"Case\":\"Union\",\"Fields\":[{\"Case\":\"SimpleSet\",\"Fields\":[{\"Case\":\"Adjointable\"}]},{\"Case\":\"SimpleSet\",\"Fields\":[{\"Case\":\"Controllable\"}]}]},\"InferredInformation\":{\"IsSelfAdjoint\":false,\"IsIntrinsic\":false}},\"Parent\":{\"Namespace\":\"Quantum.QSharpBasicArithmetics\",\"Name\":\"QuantumAdd\"},\"SourceFile\":\"C:/Demo/Quantum-Arithmetic-QSharp/QSharpBasicArithmetics/Operations.qs\",\"Position\":{\"Item1\":10,\"Item2\":4},\"HeaderRange\":{\"Item1\":{\"Line\":1,\"Column\":59},\"Item2\":{\"Line\":1,\"Column\":68}},\"Documentation\":[\"automatically generated QsAdjoint specialization for Quantum.QSharpBasicArithmetics.QuantumAdd\"]}")]
[assembly: SpecializationDeclaration("{\"Kind\":{\"Case\":\"QsControlled\"},\"TypeArguments\":{\"Case\":\"Null\"},\"Information\":{\"Affiliation\":{\"Case\":\"Union\",\"Fields\":[{\"Case\":\"SimpleSet\",\"Fields\":[{\"Case\":\"Adjointable\"}]},{\"Case\":\"SimpleSet\",\"Fields\":[{\"Case\":\"Controllable\"}]}]},\"InferredInformation\":{\"IsSelfAdjoint\":false,\"IsIntrinsic\":false}},\"Parent\":{\"Namespace\":\"Quantum.QSharpBasicArithmetics\",\"Name\":\"QuantumAdd\"},\"SourceFile\":\"C:/Demo/Quantum-Arithmetic-QSharp/QSharpBasicArithmetics/Operations.qs\",\"Position\":{\"Item1\":10,\"Item2\":4},\"HeaderRange\":{\"Item1\":{\"Line\":1,\"Column\":59},\"Item2\":{\"Line\":1,\"Column\":68}},\"Documentation\":[\"automatically generated QsControlled specialization for Quantum.QSharpBasicArithmetics.QuantumAdd\"]}")]
[assembly: SpecializationDeclaration("{\"Kind\":{\"Case\":\"QsControlledAdjoint\"},\"TypeArguments\":{\"Case\":\"Null\"},\"Information\":{\"Affiliation\":{\"Case\":\"Union\",\"Fields\":[{\"Case\":\"SimpleSet\",\"Fields\":[{\"Case\":\"Adjointable\"}]},{\"Case\":\"SimpleSet\",\"Fields\":[{\"Case\":\"Controllable\"}]}]},\"InferredInformation\":{\"IsSelfAdjoint\":false,\"IsIntrinsic\":false}},\"Parent\":{\"Namespace\":\"Quantum.QSharpBasicArithmetics\",\"Name\":\"QuantumAdd\"},\"SourceFile\":\"C:/Demo/Quantum-Arithmetic-QSharp/QSharpBasicArithmetics/Operations.qs\",\"Position\":{\"Item1\":10,\"Item2\":4},\"HeaderRange\":{\"Item1\":{\"Line\":1,\"Column\":59},\"Item2\":{\"Line\":1,\"Column\":68}},\"Documentation\":[\"automatically generated QsControlledAdjoint specialization for Quantum.QSharpBasicArithmetics.QuantumAdd\"]}")]
[assembly: CallableDeclaration("{\"Kind\":{\"Case\":\"Operation\"},\"QualifiedName\":{\"Namespace\":\"Quantum.QSharpBasicArithmetics\",\"Name\":\"TestQuantumAdd\"},\"SourceFile\":\"C:/Demo/Quantum-Arithmetic-QSharp/QSharpBasicArithmetics/Operations.qs\",\"Position\":{\"Item1\":21,\"Item2\":4},\"SymbolRange\":{\"Item1\":{\"Line\":1,\"Column\":11},\"Item2\":{\"Line\":1,\"Column\":25}},\"ArgumentTuple\":{\"Case\":\"QsTuple\",\"Fields\":[[{\"Case\":\"QsTupleItem\",\"Fields\":[{\"VariableName\":{\"Case\":\"ValidName\",\"Fields\":[\"a\"]},\"Type\":{\"Case\":\"Int\"},\"IsMutable\":false,\"HasLocalQuantumDependency\":false,\"Position\":{\"Case\":\"Null\"},\"Range\":{\"Item1\":{\"Line\":1,\"Column\":27},\"Item2\":{\"Line\":1,\"Column\":28}}}]},{\"Case\":\"QsTupleItem\",\"Fields\":[{\"VariableName\":{\"Case\":\"ValidName\",\"Fields\":[\"b\"]},\"Type\":{\"Case\":\"Int\"},\"IsMutable\":false,\"HasLocalQuantumDependency\":false,\"Position\":{\"Case\":\"Null\"},\"Range\":{\"Item1\":{\"Line\":1,\"Column\":36},\"Item2\":{\"Line\":1,\"Column\":37}}}]},{\"Case\":\"QsTupleItem\",\"Fields\":[{\"VariableName\":{\"Case\":\"ValidName\",\"Fields\":[\"n\"]},\"Type\":{\"Case\":\"Int\"},\"IsMutable\":false,\"HasLocalQuantumDependency\":false,\"Position\":{\"Case\":\"Null\"},\"Range\":{\"Item1\":{\"Line\":1,\"Column\":45},\"Item2\":{\"Line\":1,\"Column\":46}}}]}]]},\"Signature\":{\"TypeParameters\":[],\"ArgumentType\":{\"Case\":\"TupleType\",\"Fields\":[[{\"Case\":\"Int\"},{\"Case\":\"Int\"},{\"Case\":\"Int\"}]]},\"ReturnType\":{\"Case\":\"Int\"},\"Information\":{\"Affiliation\":{\"Case\":\"EmptySet\"},\"InferredInformation\":{\"IsSelfAdjoint\":false,\"IsIntrinsic\":false}}},\"Documentation\":[]}")]
[assembly: SpecializationDeclaration("{\"Kind\":{\"Case\":\"QsBody\"},\"TypeArguments\":{\"Case\":\"Null\"},\"Information\":{\"Affiliation\":{\"Case\":\"EmptySet\"},\"InferredInformation\":{\"IsSelfAdjoint\":false,\"IsIntrinsic\":false}},\"Parent\":{\"Namespace\":\"Quantum.QSharpBasicArithmetics\",\"Name\":\"TestQuantumAdd\"},\"SourceFile\":\"C:/Demo/Quantum-Arithmetic-QSharp/QSharpBasicArithmetics/Operations.qs\",\"Position\":{\"Item1\":21,\"Item2\":4},\"HeaderRange\":{\"Item1\":{\"Line\":1,\"Column\":11},\"Item2\":{\"Line\":1,\"Column\":25}},\"Documentation\":[]}")]
[assembly: CallableDeclaration("{\"Kind\":{\"Case\":\"Operation\"},\"QualifiedName\":{\"Namespace\":\"Quantum.QSharpBasicArithmetics\",\"Name\":\"TestQuantumSub\"},\"SourceFile\":\"C:/Demo/Quantum-Arithmetic-QSharp/QSharpBasicArithmetics/Operations.qs\",\"Position\":{\"Item1\":74,\"Item2\":4},\"SymbolRange\":{\"Item1\":{\"Line\":1,\"Column\":11},\"Item2\":{\"Line\":1,\"Column\":25}},\"ArgumentTuple\":{\"Case\":\"QsTuple\",\"Fields\":[[{\"Case\":\"QsTupleItem\",\"Fields\":[{\"VariableName\":{\"Case\":\"ValidName\",\"Fields\":[\"a\"]},\"Type\":{\"Case\":\"Int\"},\"IsMutable\":false,\"HasLocalQuantumDependency\":false,\"Position\":{\"Case\":\"Null\"},\"Range\":{\"Item1\":{\"Line\":1,\"Column\":27},\"Item2\":{\"Line\":1,\"Column\":28}}}]},{\"Case\":\"QsTupleItem\",\"Fields\":[{\"VariableName\":{\"Case\":\"ValidName\",\"Fields\":[\"b\"]},\"Type\":{\"Case\":\"Int\"},\"IsMutable\":false,\"HasLocalQuantumDependency\":false,\"Position\":{\"Case\":\"Null\"},\"Range\":{\"Item1\":{\"Line\":1,\"Column\":36},\"Item2\":{\"Line\":1,\"Column\":37}}}]},{\"Case\":\"QsTupleItem\",\"Fields\":[{\"VariableName\":{\"Case\":\"ValidName\",\"Fields\":[\"n\"]},\"Type\":{\"Case\":\"Int\"},\"IsMutable\":false,\"HasLocalQuantumDependency\":false,\"Position\":{\"Case\":\"Null\"},\"Range\":{\"Item1\":{\"Line\":1,\"Column\":45},\"Item2\":{\"Line\":1,\"Column\":46}}}]}]]},\"Signature\":{\"TypeParameters\":[],\"ArgumentType\":{\"Case\":\"TupleType\",\"Fields\":[[{\"Case\":\"Int\"},{\"Case\":\"Int\"},{\"Case\":\"Int\"}]]},\"ReturnType\":{\"Case\":\"Int\"},\"Information\":{\"Affiliation\":{\"Case\":\"EmptySet\"},\"InferredInformation\":{\"IsSelfAdjoint\":false,\"IsIntrinsic\":false}}},\"Documentation\":[]}")]
[assembly: SpecializationDeclaration("{\"Kind\":{\"Case\":\"QsBody\"},\"TypeArguments\":{\"Case\":\"Null\"},\"Information\":{\"Affiliation\":{\"Case\":\"EmptySet\"},\"InferredInformation\":{\"IsSelfAdjoint\":false,\"IsIntrinsic\":false}},\"Parent\":{\"Namespace\":\"Quantum.QSharpBasicArithmetics\",\"Name\":\"TestQuantumSub\"},\"SourceFile\":\"C:/Demo/Quantum-Arithmetic-QSharp/QSharpBasicArithmetics/Operations.qs\",\"Position\":{\"Item1\":74,\"Item2\":4},\"HeaderRange\":{\"Item1\":{\"Line\":1,\"Column\":11},\"Item2\":{\"Line\":1,\"Column\":25}},\"Documentation\":[]}")]
[assembly: CallableDeclaration("{\"Kind\":{\"Case\":\"Operation\"},\"QualifiedName\":{\"Namespace\":\"Quantum.QSharpBasicArithmetics\",\"Name\":\"QuantumAddByNumber\"},\"SourceFile\":\"C:/Demo/Quantum-Arithmetic-QSharp/QSharpBasicArithmetics/Operations.qs\",\"Position\":{\"Item1\":130,\"Item2\":4},\"SymbolRange\":{\"Item1\":{\"Line\":1,\"Column\":11},\"Item2\":{\"Line\":1,\"Column\":29}},\"ArgumentTuple\":{\"Case\":\"QsTuple\",\"Fields\":[[{\"Case\":\"QsTupleItem\",\"Fields\":[{\"VariableName\":{\"Case\":\"ValidName\",\"Fields\":[\"x\"]},\"Type\":{\"Case\":\"ArrayType\",\"Fields\":[{\"Case\":\"Qubit\"}]},\"IsMutable\":false,\"HasLocalQuantumDependency\":false,\"Position\":{\"Case\":\"Null\"},\"Range\":{\"Item1\":{\"Line\":1,\"Column\":31},\"Item2\":{\"Line\":1,\"Column\":32}}}]},{\"Case\":\"QsTupleItem\",\"Fields\":[{\"VariableName\":{\"Case\":\"ValidName\",\"Fields\":[\"b\"]},\"Type\":{\"Case\":\"Int\"},\"IsMutable\":false,\"HasLocalQuantumDependency\":false,\"Position\":{\"Case\":\"Null\"},\"Range\":{\"Item1\":{\"Line\":1,\"Column\":44},\"Item2\":{\"Line\":1,\"Column\":45}}}]}]]},\"Signature\":{\"TypeParameters\":[],\"ArgumentType\":{\"Case\":\"TupleType\",\"Fields\":[[{\"Case\":\"ArrayType\",\"Fields\":[{\"Case\":\"Qubit\"}]},{\"Case\":\"Int\"}]]},\"ReturnType\":{\"Case\":\"UnitType\"},\"Information\":{\"Affiliation\":{\"Case\":\"Union\",\"Fields\":[{\"Case\":\"SimpleSet\",\"Fields\":[{\"Case\":\"Adjointable\"}]},{\"Case\":\"SimpleSet\",\"Fields\":[{\"Case\":\"Controllable\"}]}]},\"InferredInformation\":{\"IsSelfAdjoint\":false,\"IsIntrinsic\":false}}},\"Documentation\":[]}")]
[assembly: SpecializationDeclaration("{\"Kind\":{\"Case\":\"QsBody\"},\"TypeArguments\":{\"Case\":\"Null\"},\"Information\":{\"Affiliation\":{\"Case\":\"Union\",\"Fields\":[{\"Case\":\"SimpleSet\",\"Fields\":[{\"Case\":\"Adjointable\"}]},{\"Case\":\"SimpleSet\",\"Fields\":[{\"Case\":\"Controllable\"}]}]},\"InferredInformation\":{\"IsSelfAdjoint\":false,\"IsIntrinsic\":false}},\"Parent\":{\"Namespace\":\"Quantum.QSharpBasicArithmetics\",\"Name\":\"QuantumAddByNumber\"},\"SourceFile\":\"C:/Demo/Quantum-Arithmetic-QSharp/QSharpBasicArithmetics/Operations.qs\",\"Position\":{\"Item1\":130,\"Item2\":4},\"HeaderRange\":{\"Item1\":{\"Line\":1,\"Column\":11},\"Item2\":{\"Line\":1,\"Column\":29}},\"Documentation\":[]}")]
[assembly: SpecializationDeclaration("{\"Kind\":{\"Case\":\"QsAdjoint\"},\"TypeArguments\":{\"Case\":\"Null\"},\"Information\":{\"Affiliation\":{\"Case\":\"Union\",\"Fields\":[{\"Case\":\"SimpleSet\",\"Fields\":[{\"Case\":\"Adjointable\"}]},{\"Case\":\"SimpleSet\",\"Fields\":[{\"Case\":\"Controllable\"}]}]},\"InferredInformation\":{\"IsSelfAdjoint\":false,\"IsIntrinsic\":false}},\"Parent\":{\"Namespace\":\"Quantum.QSharpBasicArithmetics\",\"Name\":\"QuantumAddByNumber\"},\"SourceFile\":\"C:/Demo/Quantum-Arithmetic-QSharp/QSharpBasicArithmetics/Operations.qs\",\"Position\":{\"Item1\":130,\"Item2\":4},\"HeaderRange\":{\"Item1\":{\"Line\":1,\"Column\":63},\"Item2\":{\"Line\":1,\"Column\":72}},\"Documentation\":[\"automatically generated QsAdjoint specialization for Quantum.QSharpBasicArithmetics.QuantumAddByNumber\"]}")]
[assembly: SpecializationDeclaration("{\"Kind\":{\"Case\":\"QsControlled\"},\"TypeArguments\":{\"Case\":\"Null\"},\"Information\":{\"Affiliation\":{\"Case\":\"Union\",\"Fields\":[{\"Case\":\"SimpleSet\",\"Fields\":[{\"Case\":\"Adjointable\"}]},{\"Case\":\"SimpleSet\",\"Fields\":[{\"Case\":\"Controllable\"}]}]},\"InferredInformation\":{\"IsSelfAdjoint\":false,\"IsIntrinsic\":false}},\"Parent\":{\"Namespace\":\"Quantum.QSharpBasicArithmetics\",\"Name\":\"QuantumAddByNumber\"},\"SourceFile\":\"C:/Demo/Quantum-Arithmetic-QSharp/QSharpBasicArithmetics/Operations.qs\",\"Position\":{\"Item1\":130,\"Item2\":4},\"HeaderRange\":{\"Item1\":{\"Line\":1,\"Column\":63},\"Item2\":{\"Line\":1,\"Column\":72}},\"Documentation\":[\"automatically generated QsControlled specialization for Quantum.QSharpBasicArithmetics.QuantumAddByNumber\"]}")]
[assembly: SpecializationDeclaration("{\"Kind\":{\"Case\":\"QsControlledAdjoint\"},\"TypeArguments\":{\"Case\":\"Null\"},\"Information\":{\"Affiliation\":{\"Case\":\"Union\",\"Fields\":[{\"Case\":\"SimpleSet\",\"Fields\":[{\"Case\":\"Adjointable\"}]},{\"Case\":\"SimpleSet\",\"Fields\":[{\"Case\":\"Controllable\"}]}]},\"InferredInformation\":{\"IsSelfAdjoint\":false,\"IsIntrinsic\":false}},\"Parent\":{\"Namespace\":\"Quantum.QSharpBasicArithmetics\",\"Name\":\"QuantumAddByNumber\"},\"SourceFile\":\"C:/Demo/Quantum-Arithmetic-QSharp/QSharpBasicArithmetics/Operations.qs\",\"Position\":{\"Item1\":130,\"Item2\":4},\"HeaderRange\":{\"Item1\":{\"Line\":1,\"Column\":63},\"Item2\":{\"Line\":1,\"Column\":72}},\"Documentation\":[\"automatically generated QsControlledAdjoint specialization for Quantum.QSharpBasicArithmetics.QuantumAddByNumber\"]}")]
[assembly: CallableDeclaration("{\"Kind\":{\"Case\":\"Operation\"},\"QualifiedName\":{\"Namespace\":\"Quantum.QSharpBasicArithmetics\",\"Name\":\"TestQuantumAddByNumber\"},\"SourceFile\":\"C:/Demo/Quantum-Arithmetic-QSharp/QSharpBasicArithmetics/Operations.qs\",\"Position\":{\"Item1\":145,\"Item2\":4},\"SymbolRange\":{\"Item1\":{\"Line\":1,\"Column\":11},\"Item2\":{\"Line\":1,\"Column\":33}},\"ArgumentTuple\":{\"Case\":\"QsTuple\",\"Fields\":[[{\"Case\":\"QsTupleItem\",\"Fields\":[{\"VariableName\":{\"Case\":\"ValidName\",\"Fields\":[\"a\"]},\"Type\":{\"Case\":\"Int\"},\"IsMutable\":false,\"HasLocalQuantumDependency\":false,\"Position\":{\"Case\":\"Null\"},\"Range\":{\"Item1\":{\"Line\":1,\"Column\":35},\"Item2\":{\"Line\":1,\"Column\":36}}}]},{\"Case\":\"QsTupleItem\",\"Fields\":[{\"VariableName\":{\"Case\":\"ValidName\",\"Fields\":[\"b\"]},\"Type\":{\"Case\":\"Int\"},\"IsMutable\":false,\"HasLocalQuantumDependency\":false,\"Position\":{\"Case\":\"Null\"},\"Range\":{\"Item1\":{\"Line\":1,\"Column\":44},\"Item2\":{\"Line\":1,\"Column\":45}}}]},{\"Case\":\"QsTupleItem\",\"Fields\":[{\"VariableName\":{\"Case\":\"ValidName\",\"Fields\":[\"n\"]},\"Type\":{\"Case\":\"Int\"},\"IsMutable\":false,\"HasLocalQuantumDependency\":false,\"Position\":{\"Case\":\"Null\"},\"Range\":{\"Item1\":{\"Line\":1,\"Column\":53},\"Item2\":{\"Line\":1,\"Column\":54}}}]}]]},\"Signature\":{\"TypeParameters\":[],\"ArgumentType\":{\"Case\":\"TupleType\",\"Fields\":[[{\"Case\":\"Int\"},{\"Case\":\"Int\"},{\"Case\":\"Int\"}]]},\"ReturnType\":{\"Case\":\"Int\"},\"Information\":{\"Affiliation\":{\"Case\":\"EmptySet\"},\"InferredInformation\":{\"IsSelfAdjoint\":false,\"IsIntrinsic\":false}}},\"Documentation\":[]}")]
[assembly: SpecializationDeclaration("{\"Kind\":{\"Case\":\"QsBody\"},\"TypeArguments\":{\"Case\":\"Null\"},\"Information\":{\"Affiliation\":{\"Case\":\"EmptySet\"},\"InferredInformation\":{\"IsSelfAdjoint\":false,\"IsIntrinsic\":false}},\"Parent\":{\"Namespace\":\"Quantum.QSharpBasicArithmetics\",\"Name\":\"TestQuantumAddByNumber\"},\"SourceFile\":\"C:/Demo/Quantum-Arithmetic-QSharp/QSharpBasicArithmetics/Operations.qs\",\"Position\":{\"Item1\":145,\"Item2\":4},\"HeaderRange\":{\"Item1\":{\"Line\":1,\"Column\":11},\"Item2\":{\"Line\":1,\"Column\":33}},\"Documentation\":[]}")]
[assembly: CallableDeclaration("{\"Kind\":{\"Case\":\"Operation\"},\"QualifiedName\":{\"Namespace\":\"Quantum.QSharpBasicArithmetics\",\"Name\":\"QuantumMultiply\"},\"SourceFile\":\"C:/Demo/Quantum-Arithmetic-QSharp/QSharpBasicArithmetics/Operations.qs\",\"Position\":{\"Item1\":189,\"Item2\":4},\"SymbolRange\":{\"Item1\":{\"Line\":1,\"Column\":11},\"Item2\":{\"Line\":1,\"Column\":26}},\"ArgumentTuple\":{\"Case\":\"QsTuple\",\"Fields\":[[{\"Case\":\"QsTupleItem\",\"Fields\":[{\"VariableName\":{\"Case\":\"ValidName\",\"Fields\":[\"a\"]},\"Type\":{\"Case\":\"Int\"},\"IsMutable\":false,\"HasLocalQuantumDependency\":false,\"Position\":{\"Case\":\"Null\"},\"Range\":{\"Item1\":{\"Line\":1,\"Column\":28},\"Item2\":{\"Line\":1,\"Column\":29}}}]},{\"Case\":\"QsTupleItem\",\"Fields\":[{\"VariableName\":{\"Case\":\"ValidName\",\"Fields\":[\"y\"]},\"Type\":{\"Case\":\"ArrayType\",\"Fields\":[{\"Case\":\"Qubit\"}]},\"IsMutable\":false,\"HasLocalQuantumDependency\":false,\"Position\":{\"Case\":\"Null\"},\"Range\":{\"Item1\":{\"Line\":1,\"Column\":37},\"Item2\":{\"Line\":1,\"Column\":38}}}]}]]},\"Signature\":{\"TypeParameters\":[],\"ArgumentType\":{\"Case\":\"TupleType\",\"Fields\":[[{\"Case\":\"Int\"},{\"Case\":\"ArrayType\",\"Fields\":[{\"Case\":\"Qubit\"}]}]]},\"ReturnType\":{\"Case\":\"UnitType\"},\"Information\":{\"Affiliation\":{\"Case\":\"Union\",\"Fields\":[{\"Case\":\"SimpleSet\",\"Fields\":[{\"Case\":\"Adjointable\"}]},{\"Case\":\"SimpleSet\",\"Fields\":[{\"Case\":\"Controllable\"}]}]},\"InferredInformation\":{\"IsSelfAdjoint\":false,\"IsIntrinsic\":false}}},\"Documentation\":[]}")]
[assembly: SpecializationDeclaration("{\"Kind\":{\"Case\":\"QsBody\"},\"TypeArguments\":{\"Case\":\"Null\"},\"Information\":{\"Affiliation\":{\"Case\":\"Union\",\"Fields\":[{\"Case\":\"SimpleSet\",\"Fields\":[{\"Case\":\"Adjointable\"}]},{\"Case\":\"SimpleSet\",\"Fields\":[{\"Case\":\"Controllable\"}]}]},\"InferredInformation\":{\"IsSelfAdjoint\":false,\"IsIntrinsic\":false}},\"Parent\":{\"Namespace\":\"Quantum.QSharpBasicArithmetics\",\"Name\":\"QuantumMultiply\"},\"SourceFile\":\"C:/Demo/Quantum-Arithmetic-QSharp/QSharpBasicArithmetics/Operations.qs\",\"Position\":{\"Item1\":189,\"Item2\":4},\"HeaderRange\":{\"Item1\":{\"Line\":1,\"Column\":11},\"Item2\":{\"Line\":1,\"Column\":26}},\"Documentation\":[]}")]
[assembly: SpecializationDeclaration("{\"Kind\":{\"Case\":\"QsAdjoint\"},\"TypeArguments\":{\"Case\":\"Null\"},\"Information\":{\"Affiliation\":{\"Case\":\"Union\",\"Fields\":[{\"Case\":\"SimpleSet\",\"Fields\":[{\"Case\":\"Adjointable\"}]},{\"Case\":\"SimpleSet\",\"Fields\":[{\"Case\":\"Controllable\"}]}]},\"InferredInformation\":{\"IsSelfAdjoint\":false,\"IsIntrinsic\":false}},\"Parent\":{\"Namespace\":\"Quantum.QSharpBasicArithmetics\",\"Name\":\"QuantumMultiply\"},\"SourceFile\":\"C:/Demo/Quantum-Arithmetic-QSharp/QSharpBasicArithmetics/Operations.qs\",\"Position\":{\"Item1\":189,\"Item2\":4},\"HeaderRange\":{\"Item1\":{\"Line\":1,\"Column\":60},\"Item2\":{\"Line\":1,\"Column\":69}},\"Documentation\":[\"automatically generated QsAdjoint specialization for Quantum.QSharpBasicArithmetics.QuantumMultiply\"]}")]
[assembly: SpecializationDeclaration("{\"Kind\":{\"Case\":\"QsControlled\"},\"TypeArguments\":{\"Case\":\"Null\"},\"Information\":{\"Affiliation\":{\"Case\":\"Union\",\"Fields\":[{\"Case\":\"SimpleSet\",\"Fields\":[{\"Case\":\"Adjointable\"}]},{\"Case\":\"SimpleSet\",\"Fields\":[{\"Case\":\"Controllable\"}]}]},\"InferredInformation\":{\"IsSelfAdjoint\":false,\"IsIntrinsic\":false}},\"Parent\":{\"Namespace\":\"Quantum.QSharpBasicArithmetics\",\"Name\":\"QuantumMultiply\"},\"SourceFile\":\"C:/Demo/Quantum-Arithmetic-QSharp/QSharpBasicArithmetics/Operations.qs\",\"Position\":{\"Item1\":189,\"Item2\":4},\"HeaderRange\":{\"Item1\":{\"Line\":1,\"Column\":60},\"Item2\":{\"Line\":1,\"Column\":69}},\"Documentation\":[\"automatically generated QsControlled specialization for Quantum.QSharpBasicArithmetics.QuantumMultiply\"]}")]
[assembly: SpecializationDeclaration("{\"Kind\":{\"Case\":\"QsControlledAdjoint\"},\"TypeArguments\":{\"Case\":\"Null\"},\"Information\":{\"Affiliation\":{\"Case\":\"Union\",\"Fields\":[{\"Case\":\"SimpleSet\",\"Fields\":[{\"Case\":\"Adjointable\"}]},{\"Case\":\"SimpleSet\",\"Fields\":[{\"Case\":\"Controllable\"}]}]},\"InferredInformation\":{\"IsSelfAdjoint\":false,\"IsIntrinsic\":false}},\"Parent\":{\"Namespace\":\"Quantum.QSharpBasicArithmetics\",\"Name\":\"QuantumMultiply\"},\"SourceFile\":\"C:/Demo/Quantum-Arithmetic-QSharp/QSharpBasicArithmetics/Operations.qs\",\"Position\":{\"Item1\":189,\"Item2\":4},\"HeaderRange\":{\"Item1\":{\"Line\":1,\"Column\":60},\"Item2\":{\"Line\":1,\"Column\":69}},\"Documentation\":[\"automatically generated QsControlledAdjoint specialization for Quantum.QSharpBasicArithmetics.QuantumMultiply\"]}")]
[assembly: CallableDeclaration("{\"Kind\":{\"Case\":\"Operation\"},\"QualifiedName\":{\"Namespace\":\"Quantum.QSharpBasicArithmetics\",\"Name\":\"TestQuantumMultiply\"},\"SourceFile\":\"C:/Demo/Quantum-Arithmetic-QSharp/QSharpBasicArithmetics/Operations.qs\",\"Position\":{\"Item1\":215,\"Item2\":4},\"SymbolRange\":{\"Item1\":{\"Line\":1,\"Column\":11},\"Item2\":{\"Line\":1,\"Column\":30}},\"ArgumentTuple\":{\"Case\":\"QsTuple\",\"Fields\":[[{\"Case\":\"QsTupleItem\",\"Fields\":[{\"VariableName\":{\"Case\":\"ValidName\",\"Fields\":[\"a\"]},\"Type\":{\"Case\":\"Int\"},\"IsMutable\":false,\"HasLocalQuantumDependency\":false,\"Position\":{\"Case\":\"Null\"},\"Range\":{\"Item1\":{\"Line\":1,\"Column\":32},\"Item2\":{\"Line\":1,\"Column\":33}}}]},{\"Case\":\"QsTupleItem\",\"Fields\":[{\"VariableName\":{\"Case\":\"ValidName\",\"Fields\":[\"b\"]},\"Type\":{\"Case\":\"Int\"},\"IsMutable\":false,\"HasLocalQuantumDependency\":false,\"Position\":{\"Case\":\"Null\"},\"Range\":{\"Item1\":{\"Line\":1,\"Column\":41},\"Item2\":{\"Line\":1,\"Column\":42}}}]},{\"Case\":\"QsTupleItem\",\"Fields\":[{\"VariableName\":{\"Case\":\"ValidName\",\"Fields\":[\"n\"]},\"Type\":{\"Case\":\"Int\"},\"IsMutable\":false,\"HasLocalQuantumDependency\":false,\"Position\":{\"Case\":\"Null\"},\"Range\":{\"Item1\":{\"Line\":1,\"Column\":50},\"Item2\":{\"Line\":1,\"Column\":51}}}]}]]},\"Signature\":{\"TypeParameters\":[],\"ArgumentType\":{\"Case\":\"TupleType\",\"Fields\":[[{\"Case\":\"Int\"},{\"Case\":\"Int\"},{\"Case\":\"Int\"}]]},\"ReturnType\":{\"Case\":\"Int\"},\"Information\":{\"Affiliation\":{\"Case\":\"EmptySet\"},\"InferredInformation\":{\"IsSelfAdjoint\":false,\"IsIntrinsic\":false}}},\"Documentation\":[]}")]
[assembly: SpecializationDeclaration("{\"Kind\":{\"Case\":\"QsBody\"},\"TypeArguments\":{\"Case\":\"Null\"},\"Information\":{\"Affiliation\":{\"Case\":\"EmptySet\"},\"InferredInformation\":{\"IsSelfAdjoint\":false,\"IsIntrinsic\":false}},\"Parent\":{\"Namespace\":\"Quantum.QSharpBasicArithmetics\",\"Name\":\"TestQuantumMultiply\"},\"SourceFile\":\"C:/Demo/Quantum-Arithmetic-QSharp/QSharpBasicArithmetics/Operations.qs\",\"Position\":{\"Item1\":215,\"Item2\":4},\"HeaderRange\":{\"Item1\":{\"Line\":1,\"Column\":11},\"Item2\":{\"Line\":1,\"Column\":30}},\"Documentation\":[]}")]
[assembly: CallableDeclaration("{\"Kind\":{\"Case\":\"Operation\"},\"QualifiedName\":{\"Namespace\":\"Quantum.QSharpBasicArithmetics\",\"Name\":\"QuantumExponent\"},\"SourceFile\":\"C:/Demo/Quantum-Arithmetic-QSharp/QSharpBasicArithmetics/Operations.qs\",\"Position\":{\"Item1\":259,\"Item2\":4},\"SymbolRange\":{\"Item1\":{\"Line\":1,\"Column\":11},\"Item2\":{\"Line\":1,\"Column\":26}},\"ArgumentTuple\":{\"Case\":\"QsTuple\",\"Fields\":[[{\"Case\":\"QsTupleItem\",\"Fields\":[{\"VariableName\":{\"Case\":\"ValidName\",\"Fields\":[\"a\"]},\"Type\":{\"Case\":\"Int\"},\"IsMutable\":false,\"HasLocalQuantumDependency\":false,\"Position\":{\"Case\":\"Null\"},\"Range\":{\"Item1\":{\"Line\":1,\"Column\":28},\"Item2\":{\"Line\":1,\"Column\":29}}}]},{\"Case\":\"QsTupleItem\",\"Fields\":[{\"VariableName\":{\"Case\":\"ValidName\",\"Fields\":[\"x\"]},\"Type\":{\"Case\":\"ArrayType\",\"Fields\":[{\"Case\":\"Qubit\"}]},\"IsMutable\":false,\"HasLocalQuantumDependency\":false,\"Position\":{\"Case\":\"Null\"},\"Range\":{\"Item1\":{\"Line\":1,\"Column\":37},\"Item2\":{\"Line\":1,\"Column\":38}}}]}]]},\"Signature\":{\"TypeParameters\":[],\"ArgumentType\":{\"Case\":\"TupleType\",\"Fields\":[[{\"Case\":\"Int\"},{\"Case\":\"ArrayType\",\"Fields\":[{\"Case\":\"Qubit\"}]}]]},\"ReturnType\":{\"Case\":\"UnitType\"},\"Information\":{\"Affiliation\":{\"Case\":\"EmptySet\"},\"InferredInformation\":{\"IsSelfAdjoint\":false,\"IsIntrinsic\":false}}},\"Documentation\":[]}")]
[assembly: SpecializationDeclaration("{\"Kind\":{\"Case\":\"QsBody\"},\"TypeArguments\":{\"Case\":\"Null\"},\"Information\":{\"Affiliation\":{\"Case\":\"EmptySet\"},\"InferredInformation\":{\"IsSelfAdjoint\":false,\"IsIntrinsic\":false}},\"Parent\":{\"Namespace\":\"Quantum.QSharpBasicArithmetics\",\"Name\":\"QuantumExponent\"},\"SourceFile\":\"C:/Demo/Quantum-Arithmetic-QSharp/QSharpBasicArithmetics/Operations.qs\",\"Position\":{\"Item1\":259,\"Item2\":4},\"HeaderRange\":{\"Item1\":{\"Line\":1,\"Column\":11},\"Item2\":{\"Line\":1,\"Column\":26}},\"Documentation\":[]}")]
[assembly: CallableDeclaration("{\"Kind\":{\"Case\":\"Operation\"},\"QualifiedName\":{\"Namespace\":\"Quantum.QSharpBasicArithmetics\",\"Name\":\"TestQuantumExponent\"},\"SourceFile\":\"C:/Demo/Quantum-Arithmetic-QSharp/QSharpBasicArithmetics/Operations.qs\",\"Position\":{\"Item1\":280,\"Item2\":4},\"SymbolRange\":{\"Item1\":{\"Line\":1,\"Column\":11},\"Item2\":{\"Line\":1,\"Column\":30}},\"ArgumentTuple\":{\"Case\":\"QsTuple\",\"Fields\":[[{\"Case\":\"QsTupleItem\",\"Fields\":[{\"VariableName\":{\"Case\":\"ValidName\",\"Fields\":[\"a\"]},\"Type\":{\"Case\":\"Int\"},\"IsMutable\":false,\"HasLocalQuantumDependency\":false,\"Position\":{\"Case\":\"Null\"},\"Range\":{\"Item1\":{\"Line\":1,\"Column\":32},\"Item2\":{\"Line\":1,\"Column\":33}}}]},{\"Case\":\"QsTupleItem\",\"Fields\":[{\"VariableName\":{\"Case\":\"ValidName\",\"Fields\":[\"b\"]},\"Type\":{\"Case\":\"Int\"},\"IsMutable\":false,\"HasLocalQuantumDependency\":false,\"Position\":{\"Case\":\"Null\"},\"Range\":{\"Item1\":{\"Line\":1,\"Column\":41},\"Item2\":{\"Line\":1,\"Column\":42}}}]},{\"Case\":\"QsTupleItem\",\"Fields\":[{\"VariableName\":{\"Case\":\"ValidName\",\"Fields\":[\"n\"]},\"Type\":{\"Case\":\"Int\"},\"IsMutable\":false,\"HasLocalQuantumDependency\":false,\"Position\":{\"Case\":\"Null\"},\"Range\":{\"Item1\":{\"Line\":1,\"Column\":50},\"Item2\":{\"Line\":1,\"Column\":51}}}]}]]},\"Signature\":{\"TypeParameters\":[],\"ArgumentType\":{\"Case\":\"TupleType\",\"Fields\":[[{\"Case\":\"Int\"},{\"Case\":\"Int\"},{\"Case\":\"Int\"}]]},\"ReturnType\":{\"Case\":\"Int\"},\"Information\":{\"Affiliation\":{\"Case\":\"EmptySet\"},\"InferredInformation\":{\"IsSelfAdjoint\":false,\"IsIntrinsic\":false}}},\"Documentation\":[]}")]
[assembly: SpecializationDeclaration("{\"Kind\":{\"Case\":\"QsBody\"},\"TypeArguments\":{\"Case\":\"Null\"},\"Information\":{\"Affiliation\":{\"Case\":\"EmptySet\"},\"InferredInformation\":{\"IsSelfAdjoint\":false,\"IsIntrinsic\":false}},\"Parent\":{\"Namespace\":\"Quantum.QSharpBasicArithmetics\",\"Name\":\"TestQuantumExponent\"},\"SourceFile\":\"C:/Demo/Quantum-Arithmetic-QSharp/QSharpBasicArithmetics/Operations.qs\",\"Position\":{\"Item1\":280,\"Item2\":4},\"HeaderRange\":{\"Item1\":{\"Line\":1,\"Column\":11},\"Item2\":{\"Line\":1,\"Column\":30}},\"Documentation\":[]}")]
[assembly: CallableDeclaration("{\"Kind\":{\"Case\":\"Operation\"},\"QualifiedName\":{\"Namespace\":\"Quantum.QSharpBasicArithmetics\",\"Name\":\"QuantumAddByModulus\"},\"SourceFile\":\"C:/Demo/Quantum-Arithmetic-QSharp/QSharpBasicArithmetics/Operations.qs\",\"Position\":{\"Item1\":321,\"Item2\":4},\"SymbolRange\":{\"Item1\":{\"Line\":1,\"Column\":11},\"Item2\":{\"Line\":1,\"Column\":30}},\"ArgumentTuple\":{\"Case\":\"QsTuple\",\"Fields\":[[{\"Case\":\"QsTupleItem\",\"Fields\":[{\"VariableName\":{\"Case\":\"ValidName\",\"Fields\":[\"N\"]},\"Type\":{\"Case\":\"Int\"},\"IsMutable\":false,\"HasLocalQuantumDependency\":false,\"Position\":{\"Case\":\"Null\"},\"Range\":{\"Item1\":{\"Line\":1,\"Column\":32},\"Item2\":{\"Line\":1,\"Column\":33}}}]},{\"Case\":\"QsTupleItem\",\"Fields\":[{\"VariableName\":{\"Case\":\"ValidName\",\"Fields\":[\"x\"]},\"Type\":{\"Case\":\"ArrayType\",\"Fields\":[{\"Case\":\"Qubit\"}]},\"IsMutable\":false,\"HasLocalQuantumDependency\":false,\"Position\":{\"Case\":\"Null\"},\"Range\":{\"Item1\":{\"Line\":1,\"Column\":41},\"Item2\":{\"Line\":1,\"Column\":42}}}]},{\"Case\":\"QsTupleItem\",\"Fields\":[{\"VariableName\":{\"Case\":\"ValidName\",\"Fields\":[\"y\"]},\"Type\":{\"Case\":\"ArrayType\",\"Fields\":[{\"Case\":\"Qubit\"}]},\"IsMutable\":false,\"HasLocalQuantumDependency\":false,\"Position\":{\"Case\":\"Null\"},\"Range\":{\"Item1\":{\"Line\":1,\"Column\":54},\"Item2\":{\"Line\":1,\"Column\":55}}}]}]]},\"Signature\":{\"TypeParameters\":[],\"ArgumentType\":{\"Case\":\"TupleType\",\"Fields\":[[{\"Case\":\"Int\"},{\"Case\":\"ArrayType\",\"Fields\":[{\"Case\":\"Qubit\"}]},{\"Case\":\"ArrayType\",\"Fields\":[{\"Case\":\"Qubit\"}]}]]},\"ReturnType\":{\"Case\":\"UnitType\"},\"Information\":{\"Affiliation\":{\"Case\":\"Union\",\"Fields\":[{\"Case\":\"SimpleSet\",\"Fields\":[{\"Case\":\"Adjointable\"}]},{\"Case\":\"SimpleSet\",\"Fields\":[{\"Case\":\"Controllable\"}]}]},\"InferredInformation\":{\"IsSelfAdjoint\":false,\"IsIntrinsic\":false}}},\"Documentation\":[]}")]
[assembly: SpecializationDeclaration("{\"Kind\":{\"Case\":\"QsBody\"},\"TypeArguments\":{\"Case\":\"Null\"},\"Information\":{\"Affiliation\":{\"Case\":\"Union\",\"Fields\":[{\"Case\":\"SimpleSet\",\"Fields\":[{\"Case\":\"Adjointable\"}]},{\"Case\":\"SimpleSet\",\"Fields\":[{\"Case\":\"Controllable\"}]}]},\"InferredInformation\":{\"IsSelfAdjoint\":false,\"IsIntrinsic\":false}},\"Parent\":{\"Namespace\":\"Quantum.QSharpBasicArithmetics\",\"Name\":\"QuantumAddByModulus\"},\"SourceFile\":\"C:/Demo/Quantum-Arithmetic-QSharp/QSharpBasicArithmetics/Operations.qs\",\"Position\":{\"Item1\":321,\"Item2\":4},\"HeaderRange\":{\"Item1\":{\"Line\":1,\"Column\":11},\"Item2\":{\"Line\":1,\"Column\":30}},\"Documentation\":[]}")]
[assembly: SpecializationDeclaration("{\"Kind\":{\"Case\":\"QsAdjoint\"},\"TypeArguments\":{\"Case\":\"Null\"},\"Information\":{\"Affiliation\":{\"Case\":\"Union\",\"Fields\":[{\"Case\":\"SimpleSet\",\"Fields\":[{\"Case\":\"Adjointable\"}]},{\"Case\":\"SimpleSet\",\"Fields\":[{\"Case\":\"Controllable\"}]}]},\"InferredInformation\":{\"IsSelfAdjoint\":false,\"IsIntrinsic\":false}},\"Parent\":{\"Namespace\":\"Quantum.QSharpBasicArithmetics\",\"Name\":\"QuantumAddByModulus\"},\"SourceFile\":\"C:/Demo/Quantum-Arithmetic-QSharp/QSharpBasicArithmetics/Operations.qs\",\"Position\":{\"Item1\":321,\"Item2\":4},\"HeaderRange\":{\"Item1\":{\"Line\":1,\"Column\":77},\"Item2\":{\"Line\":1,\"Column\":86}},\"Documentation\":[\"automatically generated QsAdjoint specialization for Quantum.QSharpBasicArithmetics.QuantumAddByModulus\"]}")]
[assembly: SpecializationDeclaration("{\"Kind\":{\"Case\":\"QsControlled\"},\"TypeArguments\":{\"Case\":\"Null\"},\"Information\":{\"Affiliation\":{\"Case\":\"Union\",\"Fields\":[{\"Case\":\"SimpleSet\",\"Fields\":[{\"Case\":\"Adjointable\"}]},{\"Case\":\"SimpleSet\",\"Fields\":[{\"Case\":\"Controllable\"}]}]},\"InferredInformation\":{\"IsSelfAdjoint\":false,\"IsIntrinsic\":false}},\"Parent\":{\"Namespace\":\"Quantum.QSharpBasicArithmetics\",\"Name\":\"QuantumAddByModulus\"},\"SourceFile\":\"C:/Demo/Quantum-Arithmetic-QSharp/QSharpBasicArithmetics/Operations.qs\",\"Position\":{\"Item1\":321,\"Item2\":4},\"HeaderRange\":{\"Item1\":{\"Line\":1,\"Column\":77},\"Item2\":{\"Line\":1,\"Column\":86}},\"Documentation\":[\"automatically generated QsControlled specialization for Quantum.QSharpBasicArithmetics.QuantumAddByModulus\"]}")]
[assembly: SpecializationDeclaration("{\"Kind\":{\"Case\":\"QsControlledAdjoint\"},\"TypeArguments\":{\"Case\":\"Null\"},\"Information\":{\"Affiliation\":{\"Case\":\"Union\",\"Fields\":[{\"Case\":\"SimpleSet\",\"Fields\":[{\"Case\":\"Adjointable\"}]},{\"Case\":\"SimpleSet\",\"Fields\":[{\"Case\":\"Controllable\"}]}]},\"InferredInformation\":{\"IsSelfAdjoint\":false,\"IsIntrinsic\":false}},\"Parent\":{\"Namespace\":\"Quantum.QSharpBasicArithmetics\",\"Name\":\"QuantumAddByModulus\"},\"SourceFile\":\"C:/Demo/Quantum-Arithmetic-QSharp/QSharpBasicArithmetics/Operations.qs\",\"Position\":{\"Item1\":321,\"Item2\":4},\"HeaderRange\":{\"Item1\":{\"Line\":1,\"Column\":77},\"Item2\":{\"Line\":1,\"Column\":86}},\"Documentation\":[\"automatically generated QsControlledAdjoint specialization for Quantum.QSharpBasicArithmetics.QuantumAddByModulus\"]}")]
[assembly: CallableDeclaration("{\"Kind\":{\"Case\":\"Operation\"},\"QualifiedName\":{\"Namespace\":\"Quantum.QSharpBasicArithmetics\",\"Name\":\"QuantumMultiplyByModulus\"},\"SourceFile\":\"C:/Demo/Quantum-Arithmetic-QSharp/QSharpBasicArithmetics/Operations.qs\",\"Position\":{\"Item1\":350,\"Item2\":4},\"SymbolRange\":{\"Item1\":{\"Line\":1,\"Column\":11},\"Item2\":{\"Line\":1,\"Column\":35}},\"ArgumentTuple\":{\"Case\":\"QsTuple\",\"Fields\":[[{\"Case\":\"QsTupleItem\",\"Fields\":[{\"VariableName\":{\"Case\":\"ValidName\",\"Fields\":[\"N\"]},\"Type\":{\"Case\":\"Int\"},\"IsMutable\":false,\"HasLocalQuantumDependency\":false,\"Position\":{\"Case\":\"Null\"},\"Range\":{\"Item1\":{\"Line\":1,\"Column\":37},\"Item2\":{\"Line\":1,\"Column\":38}}}]},{\"Case\":\"QsTupleItem\",\"Fields\":[{\"VariableName\":{\"Case\":\"ValidName\",\"Fields\":[\"a\"]},\"Type\":{\"Case\":\"Int\"},\"IsMutable\":false,\"HasLocalQuantumDependency\":false,\"Position\":{\"Case\":\"Null\"},\"Range\":{\"Item1\":{\"Line\":1,\"Column\":46},\"Item2\":{\"Line\":1,\"Column\":47}}}]},{\"Case\":\"QsTupleItem\",\"Fields\":[{\"VariableName\":{\"Case\":\"ValidName\",\"Fields\":[\"y\"]},\"Type\":{\"Case\":\"ArrayType\",\"Fields\":[{\"Case\":\"Qubit\"}]},\"IsMutable\":false,\"HasLocalQuantumDependency\":false,\"Position\":{\"Case\":\"Null\"},\"Range\":{\"Item1\":{\"Line\":1,\"Column\":55},\"Item2\":{\"Line\":1,\"Column\":56}}}]}]]},\"Signature\":{\"TypeParameters\":[],\"ArgumentType\":{\"Case\":\"TupleType\",\"Fields\":[[{\"Case\":\"Int\"},{\"Case\":\"Int\"},{\"Case\":\"ArrayType\",\"Fields\":[{\"Case\":\"Qubit\"}]}]]},\"ReturnType\":{\"Case\":\"UnitType\"},\"Information\":{\"Affiliation\":{\"Case\":\"Union\",\"Fields\":[{\"Case\":\"SimpleSet\",\"Fields\":[{\"Case\":\"Adjointable\"}]},{\"Case\":\"SimpleSet\",\"Fields\":[{\"Case\":\"Controllable\"}]}]},\"InferredInformation\":{\"IsSelfAdjoint\":false,\"IsIntrinsic\":false}}},\"Documentation\":[]}")]
[assembly: SpecializationDeclaration("{\"Kind\":{\"Case\":\"QsBody\"},\"TypeArguments\":{\"Case\":\"Null\"},\"Information\":{\"Affiliation\":{\"Case\":\"Union\",\"Fields\":[{\"Case\":\"SimpleSet\",\"Fields\":[{\"Case\":\"Adjointable\"}]},{\"Case\":\"SimpleSet\",\"Fields\":[{\"Case\":\"Controllable\"}]}]},\"InferredInformation\":{\"IsSelfAdjoint\":false,\"IsIntrinsic\":false}},\"Parent\":{\"Namespace\":\"Quantum.QSharpBasicArithmetics\",\"Name\":\"QuantumMultiplyByModulus\"},\"SourceFile\":\"C:/Demo/Quantum-Arithmetic-QSharp/QSharpBasicArithmetics/Operations.qs\",\"Position\":{\"Item1\":350,\"Item2\":4},\"HeaderRange\":{\"Item1\":{\"Line\":1,\"Column\":11},\"Item2\":{\"Line\":1,\"Column\":35}},\"Documentation\":[]}")]
[assembly: SpecializationDeclaration("{\"Kind\":{\"Case\":\"QsAdjoint\"},\"TypeArguments\":{\"Case\":\"Null\"},\"Information\":{\"Affiliation\":{\"Case\":\"Union\",\"Fields\":[{\"Case\":\"SimpleSet\",\"Fields\":[{\"Case\":\"Adjointable\"}]},{\"Case\":\"SimpleSet\",\"Fields\":[{\"Case\":\"Controllable\"}]}]},\"InferredInformation\":{\"IsSelfAdjoint\":false,\"IsIntrinsic\":false}},\"Parent\":{\"Namespace\":\"Quantum.QSharpBasicArithmetics\",\"Name\":\"QuantumMultiplyByModulus\"},\"SourceFile\":\"C:/Demo/Quantum-Arithmetic-QSharp/QSharpBasicArithmetics/Operations.qs\",\"Position\":{\"Item1\":350,\"Item2\":4},\"HeaderRange\":{\"Item1\":{\"Line\":1,\"Column\":78},\"Item2\":{\"Line\":1,\"Column\":87}},\"Documentation\":[\"automatically generated QsAdjoint specialization for Quantum.QSharpBasicArithmetics.QuantumMultiplyByModulus\"]}")]
[assembly: SpecializationDeclaration("{\"Kind\":{\"Case\":\"QsControlled\"},\"TypeArguments\":{\"Case\":\"Null\"},\"Information\":{\"Affiliation\":{\"Case\":\"Union\",\"Fields\":[{\"Case\":\"SimpleSet\",\"Fields\":[{\"Case\":\"Adjointable\"}]},{\"Case\":\"SimpleSet\",\"Fields\":[{\"Case\":\"Controllable\"}]}]},\"InferredInformation\":{\"IsSelfAdjoint\":false,\"IsIntrinsic\":false}},\"Parent\":{\"Namespace\":\"Quantum.QSharpBasicArithmetics\",\"Name\":\"QuantumMultiplyByModulus\"},\"SourceFile\":\"C:/Demo/Quantum-Arithmetic-QSharp/QSharpBasicArithmetics/Operations.qs\",\"Position\":{\"Item1\":350,\"Item2\":4},\"HeaderRange\":{\"Item1\":{\"Line\":1,\"Column\":78},\"Item2\":{\"Line\":1,\"Column\":87}},\"Documentation\":[\"automatically generated QsControlled specialization for Quantum.QSharpBasicArithmetics.QuantumMultiplyByModulus\"]}")]
[assembly: SpecializationDeclaration("{\"Kind\":{\"Case\":\"QsControlledAdjoint\"},\"TypeArguments\":{\"Case\":\"Null\"},\"Information\":{\"Affiliation\":{\"Case\":\"Union\",\"Fields\":[{\"Case\":\"SimpleSet\",\"Fields\":[{\"Case\":\"Adjointable\"}]},{\"Case\":\"SimpleSet\",\"Fields\":[{\"Case\":\"Controllable\"}]}]},\"InferredInformation\":{\"IsSelfAdjoint\":false,\"IsIntrinsic\":false}},\"Parent\":{\"Namespace\":\"Quantum.QSharpBasicArithmetics\",\"Name\":\"QuantumMultiplyByModulus\"},\"SourceFile\":\"C:/Demo/Quantum-Arithmetic-QSharp/QSharpBasicArithmetics/Operations.qs\",\"Position\":{\"Item1\":350,\"Item2\":4},\"HeaderRange\":{\"Item1\":{\"Line\":1,\"Column\":78},\"Item2\":{\"Line\":1,\"Column\":87}},\"Documentation\":[\"automatically generated QsControlledAdjoint specialization for Quantum.QSharpBasicArithmetics.QuantumMultiplyByModulus\"]}")]
[assembly: CallableDeclaration("{\"Kind\":{\"Case\":\"Operation\"},\"QualifiedName\":{\"Namespace\":\"Quantum.QSharpBasicArithmetics\",\"Name\":\"QuantumExponentByModulus\"},\"SourceFile\":\"C:/Demo/Quantum-Arithmetic-QSharp/QSharpBasicArithmetics/Operations.qs\",\"Position\":{\"Item1\":384,\"Item2\":4},\"SymbolRange\":{\"Item1\":{\"Line\":1,\"Column\":11},\"Item2\":{\"Line\":1,\"Column\":35}},\"ArgumentTuple\":{\"Case\":\"QsTuple\",\"Fields\":[[{\"Case\":\"QsTupleItem\",\"Fields\":[{\"VariableName\":{\"Case\":\"ValidName\",\"Fields\":[\"N\"]},\"Type\":{\"Case\":\"Int\"},\"IsMutable\":false,\"HasLocalQuantumDependency\":false,\"Position\":{\"Case\":\"Null\"},\"Range\":{\"Item1\":{\"Line\":1,\"Column\":37},\"Item2\":{\"Line\":1,\"Column\":38}}}]},{\"Case\":\"QsTupleItem\",\"Fields\":[{\"VariableName\":{\"Case\":\"ValidName\",\"Fields\":[\"a\"]},\"Type\":{\"Case\":\"Int\"},\"IsMutable\":false,\"HasLocalQuantumDependency\":false,\"Position\":{\"Case\":\"Null\"},\"Range\":{\"Item1\":{\"Line\":1,\"Column\":46},\"Item2\":{\"Line\":1,\"Column\":47}}}]},{\"Case\":\"QsTupleItem\",\"Fields\":[{\"VariableName\":{\"Case\":\"ValidName\",\"Fields\":[\"x\"]},\"Type\":{\"Case\":\"ArrayType\",\"Fields\":[{\"Case\":\"Qubit\"}]},\"IsMutable\":false,\"HasLocalQuantumDependency\":false,\"Position\":{\"Case\":\"Null\"},\"Range\":{\"Item1\":{\"Line\":1,\"Column\":55},\"Item2\":{\"Line\":1,\"Column\":56}}}]}]]},\"Signature\":{\"TypeParameters\":[],\"ArgumentType\":{\"Case\":\"TupleType\",\"Fields\":[[{\"Case\":\"Int\"},{\"Case\":\"Int\"},{\"Case\":\"ArrayType\",\"Fields\":[{\"Case\":\"Qubit\"}]}]]},\"ReturnType\":{\"Case\":\"UnitType\"},\"Information\":{\"Affiliation\":{\"Case\":\"EmptySet\"},\"InferredInformation\":{\"IsSelfAdjoint\":false,\"IsIntrinsic\":false}}},\"Documentation\":[]}")]
[assembly: SpecializationDeclaration("{\"Kind\":{\"Case\":\"QsBody\"},\"TypeArguments\":{\"Case\":\"Null\"},\"Information\":{\"Affiliation\":{\"Case\":\"EmptySet\"},\"InferredInformation\":{\"IsSelfAdjoint\":false,\"IsIntrinsic\":false}},\"Parent\":{\"Namespace\":\"Quantum.QSharpBasicArithmetics\",\"Name\":\"QuantumExponentByModulus\"},\"SourceFile\":\"C:/Demo/Quantum-Arithmetic-QSharp/QSharpBasicArithmetics/Operations.qs\",\"Position\":{\"Item1\":384,\"Item2\":4},\"HeaderRange\":{\"Item1\":{\"Line\":1,\"Column\":11},\"Item2\":{\"Line\":1,\"Column\":35}},\"Documentation\":[]}")]
[assembly: CallableDeclaration("{\"Kind\":{\"Case\":\"Operation\"},\"QualifiedName\":{\"Namespace\":\"Quantum.QSharpBasicArithmetics\",\"Name\":\"TestQuantumAddByModulus\"},\"SourceFile\":\"C:/Demo/Quantum-Arithmetic-QSharp/QSharpBasicArithmetics/Operations.qs\",\"Position\":{\"Item1\":405,\"Item2\":4},\"SymbolRange\":{\"Item1\":{\"Line\":1,\"Column\":11},\"Item2\":{\"Line\":1,\"Column\":34}},\"ArgumentTuple\":{\"Case\":\"QsTuple\",\"Fields\":[[{\"Case\":\"QsTupleItem\",\"Fields\":[{\"VariableName\":{\"Case\":\"ValidName\",\"Fields\":[\"a\"]},\"Type\":{\"Case\":\"Int\"},\"IsMutable\":false,\"HasLocalQuantumDependency\":false,\"Position\":{\"Case\":\"Null\"},\"Range\":{\"Item1\":{\"Line\":1,\"Column\":36},\"Item2\":{\"Line\":1,\"Column\":37}}}]},{\"Case\":\"QsTupleItem\",\"Fields\":[{\"VariableName\":{\"Case\":\"ValidName\",\"Fields\":[\"b\"]},\"Type\":{\"Case\":\"Int\"},\"IsMutable\":false,\"HasLocalQuantumDependency\":false,\"Position\":{\"Case\":\"Null\"},\"Range\":{\"Item1\":{\"Line\":1,\"Column\":45},\"Item2\":{\"Line\":1,\"Column\":46}}}]},{\"Case\":\"QsTupleItem\",\"Fields\":[{\"VariableName\":{\"Case\":\"ValidName\",\"Fields\":[\"n\"]},\"Type\":{\"Case\":\"Int\"},\"IsMutable\":false,\"HasLocalQuantumDependency\":false,\"Position\":{\"Case\":\"Null\"},\"Range\":{\"Item1\":{\"Line\":1,\"Column\":54},\"Item2\":{\"Line\":1,\"Column\":55}}}]},{\"Case\":\"QsTupleItem\",\"Fields\":[{\"VariableName\":{\"Case\":\"ValidName\",\"Fields\":[\"N\"]},\"Type\":{\"Case\":\"Int\"},\"IsMutable\":false,\"HasLocalQuantumDependency\":false,\"Position\":{\"Case\":\"Null\"},\"Range\":{\"Item1\":{\"Line\":1,\"Column\":63},\"Item2\":{\"Line\":1,\"Column\":64}}}]}]]},\"Signature\":{\"TypeParameters\":[],\"ArgumentType\":{\"Case\":\"TupleType\",\"Fields\":[[{\"Case\":\"Int\"},{\"Case\":\"Int\"},{\"Case\":\"Int\"},{\"Case\":\"Int\"}]]},\"ReturnType\":{\"Case\":\"Int\"},\"Information\":{\"Affiliation\":{\"Case\":\"EmptySet\"},\"InferredInformation\":{\"IsSelfAdjoint\":false,\"IsIntrinsic\":false}}},\"Documentation\":[]}")]
[assembly: SpecializationDeclaration("{\"Kind\":{\"Case\":\"QsBody\"},\"TypeArguments\":{\"Case\":\"Null\"},\"Information\":{\"Affiliation\":{\"Case\":\"EmptySet\"},\"InferredInformation\":{\"IsSelfAdjoint\":false,\"IsIntrinsic\":false}},\"Parent\":{\"Namespace\":\"Quantum.QSharpBasicArithmetics\",\"Name\":\"TestQuantumAddByModulus\"},\"SourceFile\":\"C:/Demo/Quantum-Arithmetic-QSharp/QSharpBasicArithmetics/Operations.qs\",\"Position\":{\"Item1\":405,\"Item2\":4},\"HeaderRange\":{\"Item1\":{\"Line\":1,\"Column\":11},\"Item2\":{\"Line\":1,\"Column\":34}},\"Documentation\":[]}")]
[assembly: CallableDeclaration("{\"Kind\":{\"Case\":\"Operation\"},\"QualifiedName\":{\"Namespace\":\"Quantum.QSharpBasicArithmetics\",\"Name\":\"QFTImpl\"},\"SourceFile\":\"C:/Demo/Quantum-Arithmetic-QSharp/QSharpBasicArithmetics/Operations.qs\",\"Position\":{\"Item1\":466,\"Item2\":4},\"SymbolRange\":{\"Item1\":{\"Line\":1,\"Column\":11},\"Item2\":{\"Line\":1,\"Column\":18}},\"ArgumentTuple\":{\"Case\":\"QsTuple\",\"Fields\":[[{\"Case\":\"QsTupleItem\",\"Fields\":[{\"VariableName\":{\"Case\":\"ValidName\",\"Fields\":[\"qs\"]},\"Type\":{\"Case\":\"ArrayType\",\"Fields\":[{\"Case\":\"Qubit\"}]},\"IsMutable\":false,\"HasLocalQuantumDependency\":false,\"Position\":{\"Case\":\"Null\"},\"Range\":{\"Item1\":{\"Line\":1,\"Column\":20},\"Item2\":{\"Line\":1,\"Column\":22}}}]}]]},\"Signature\":{\"TypeParameters\":[],\"ArgumentType\":{\"Case\":\"ArrayType\",\"Fields\":[{\"Case\":\"Qubit\"}]},\"ReturnType\":{\"Case\":\"UnitType\"},\"Information\":{\"Affiliation\":{\"Case\":\"Union\",\"Fields\":[{\"Case\":\"SimpleSet\",\"Fields\":[{\"Case\":\"Adjointable\"}]},{\"Case\":\"SimpleSet\",\"Fields\":[{\"Case\":\"Controllable\"}]}]},\"InferredInformation\":{\"IsSelfAdjoint\":false,\"IsIntrinsic\":false}}},\"Documentation\":[]}")]
[assembly: SpecializationDeclaration("{\"Kind\":{\"Case\":\"QsBody\"},\"TypeArguments\":{\"Case\":\"Null\"},\"Information\":{\"Affiliation\":{\"Case\":\"Union\",\"Fields\":[{\"Case\":\"SimpleSet\",\"Fields\":[{\"Case\":\"Adjointable\"}]},{\"Case\":\"SimpleSet\",\"Fields\":[{\"Case\":\"Controllable\"}]}]},\"InferredInformation\":{\"IsSelfAdjoint\":false,\"IsIntrinsic\":false}},\"Parent\":{\"Namespace\":\"Quantum.QSharpBasicArithmetics\",\"Name\":\"QFTImpl\"},\"SourceFile\":\"C:/Demo/Quantum-Arithmetic-QSharp/QSharpBasicArithmetics/Operations.qs\",\"Position\":{\"Item1\":468,\"Item2\":8},\"HeaderRange\":{\"Item1\":{\"Line\":1,\"Column\":1},\"Item2\":{\"Line\":1,\"Column\":5}},\"Documentation\":[]}")]
[assembly: SpecializationDeclaration("{\"Kind\":{\"Case\":\"QsAdjoint\"},\"TypeArguments\":{\"Case\":\"Null\"},\"Information\":{\"Affiliation\":{\"Case\":\"Union\",\"Fields\":[{\"Case\":\"SimpleSet\",\"Fields\":[{\"Case\":\"Adjointable\"}]},{\"Case\":\"SimpleSet\",\"Fields\":[{\"Case\":\"Controllable\"}]}]},\"InferredInformation\":{\"IsSelfAdjoint\":false,\"IsIntrinsic\":false}},\"Parent\":{\"Namespace\":\"Quantum.QSharpBasicArithmetics\",\"Name\":\"QFTImpl\"},\"SourceFile\":\"C:/Demo/Quantum-Arithmetic-QSharp/QSharpBasicArithmetics/Operations.qs\",\"Position\":{\"Item1\":466,\"Item2\":4},\"HeaderRange\":{\"Item1\":{\"Line\":1,\"Column\":44},\"Item2\":{\"Line\":1,\"Column\":53}},\"Documentation\":[\"automatically generated QsAdjoint specialization for Quantum.QSharpBasicArithmetics.QFTImpl\"]}")]
[assembly: SpecializationDeclaration("{\"Kind\":{\"Case\":\"QsControlled\"},\"TypeArguments\":{\"Case\":\"Null\"},\"Information\":{\"Affiliation\":{\"Case\":\"Union\",\"Fields\":[{\"Case\":\"SimpleSet\",\"Fields\":[{\"Case\":\"Adjointable\"}]},{\"Case\":\"SimpleSet\",\"Fields\":[{\"Case\":\"Controllable\"}]}]},\"InferredInformation\":{\"IsSelfAdjoint\":false,\"IsIntrinsic\":false}},\"Parent\":{\"Namespace\":\"Quantum.QSharpBasicArithmetics\",\"Name\":\"QFTImpl\"},\"SourceFile\":\"C:/Demo/Quantum-Arithmetic-QSharp/QSharpBasicArithmetics/Operations.qs\",\"Position\":{\"Item1\":466,\"Item2\":4},\"HeaderRange\":{\"Item1\":{\"Line\":1,\"Column\":44},\"Item2\":{\"Line\":1,\"Column\":53}},\"Documentation\":[\"automatically generated QsControlled specialization for Quantum.QSharpBasicArithmetics.QFTImpl\"]}")]
[assembly: SpecializationDeclaration("{\"Kind\":{\"Case\":\"QsControlledAdjoint\"},\"TypeArguments\":{\"Case\":\"Null\"},\"Information\":{\"Affiliation\":{\"Case\":\"Union\",\"Fields\":[{\"Case\":\"SimpleSet\",\"Fields\":[{\"Case\":\"Adjointable\"}]},{\"Case\":\"SimpleSet\",\"Fields\":[{\"Case\":\"Controllable\"}]}]},\"InferredInformation\":{\"IsSelfAdjoint\":false,\"IsIntrinsic\":false}},\"Parent\":{\"Namespace\":\"Quantum.QSharpBasicArithmetics\",\"Name\":\"QFTImpl\"},\"SourceFile\":\"C:/Demo/Quantum-Arithmetic-QSharp/QSharpBasicArithmetics/Operations.qs\",\"Position\":{\"Item1\":466,\"Item2\":4},\"HeaderRange\":{\"Item1\":{\"Line\":1,\"Column\":44},\"Item2\":{\"Line\":1,\"Column\":53}},\"Documentation\":[\"automatically generated QsControlledAdjoint specialization for Quantum.QSharpBasicArithmetics.QFTImpl\"]}")]
#line hidden
namespace Quantum.QSharpBasicArithmetics
{
    public class QuantumAdd : Unitary<(IQArray<Qubit>,IQArray<Qubit>)>, ICallable
    {
        public QuantumAdd(IOperationFactory m) : base(m)
        {
        }

        public class In : QTuple<(IQArray<Qubit>,IQArray<Qubit>)>, IApplyData
        {
            public In((IQArray<Qubit>,IQArray<Qubit>) data) : base(data)
            {
            }

            System.Collections.Generic.IEnumerable<Qubit> IApplyData.Qubits => Qubit.Concat(((IApplyData)Data.Item1)?.Qubits, ((IApplyData)Data.Item2)?.Qubits);
        }

        String ICallable.Name => "QuantumAdd";
        String ICallable.FullName => "Quantum.QSharpBasicArithmetics.QuantumAdd";
        protected ICallable Length
        {
            get;
            set;
        }

        protected ICallable<Range, Range> RangeReverse
        {
            get;
            set;
        }

        protected IUnitary<(Int64,Int64,Qubit)> MicrosoftQuantumIntrinsicR1Frac
        {
            get;
            set;
        }

        protected IUnitary<IQArray<Qubit>> QFTImpl
        {
            get;
            set;
        }

        public override Func<(IQArray<Qubit>,IQArray<Qubit>), QVoid> Body => (__in__) =>
        {
            var (x,y) = __in__;
#line 12 "C:\\Demo\\Quantum-Arithmetic-QSharp\\QSharpBasicArithmetics\\Operations.qs"
            var n = x.Length;
#line 13 "C:\\Demo\\Quantum-Arithmetic-QSharp\\QSharpBasicArithmetics\\Operations.qs"
            QFTImpl.Apply(y);
#line 14 "C:\\Demo\\Quantum-Arithmetic-QSharp\\QSharpBasicArithmetics\\Operations.qs"
            foreach (var i in new Range(0L, (n - 1L)))
#line hidden
            {
#line 15 "C:\\Demo\\Quantum-Arithmetic-QSharp\\QSharpBasicArithmetics\\Operations.qs"
                foreach (var j in new Range(0L, ((n - 1L) - i)))
#line hidden
                {
#line 16 "C:\\Demo\\Quantum-Arithmetic-QSharp\\QSharpBasicArithmetics\\Operations.qs"
                    MicrosoftQuantumIntrinsicR1Frac.Controlled.Apply((new QArray<Qubit>(x[(i + j)]), (2L, (j + 1L), y[((n - 1L) - i)])));
                }
            }

#line 19 "C:\\Demo\\Quantum-Arithmetic-QSharp\\QSharpBasicArithmetics\\Operations.qs"
            QFTImpl.Adjoint.Apply(y);
#line hidden
            return QVoid.Instance;
        }

        ;
        public override Func<(IQArray<Qubit>,IQArray<Qubit>), QVoid> AdjointBody => (__in__) =>
        {
            var (x,y) = __in__;
#line hidden
            var n = x.Length;
#line hidden
            QFTImpl.Adjoint.Adjoint.Apply(y);
#line hidden
            foreach (var i in RangeReverse.Apply(new Range(0L, (n - 1L))))
#line hidden
            {
#line hidden
                foreach (var j in RangeReverse.Apply(new Range(0L, ((n - 1L) - i))))
#line hidden
                {
#line hidden
                    MicrosoftQuantumIntrinsicR1Frac.Controlled.Adjoint.Apply((new QArray<Qubit>(x[(i + j)]), (2L, (j + 1L), y[((n - 1L) - i)])));
                }
            }

#line hidden
            QFTImpl.Adjoint.Apply(y);
#line hidden
            return QVoid.Instance;
        }

        ;
        public override Func<(IQArray<Qubit>,(IQArray<Qubit>,IQArray<Qubit>)), QVoid> ControlledBody => (__in__) =>
        {
            var (__controlQubits__,(x,y)) = __in__;
#line hidden
            var n = x.Length;
#line hidden
            QFTImpl.Controlled.Apply((__controlQubits__, y));
#line hidden
            foreach (var i in new Range(0L, (n - 1L)))
#line hidden
            {
#line hidden
                foreach (var j in new Range(0L, ((n - 1L) - i)))
#line hidden
                {
#line hidden
                    MicrosoftQuantumIntrinsicR1Frac.Controlled.Controlled.Apply((__controlQubits__, (new QArray<Qubit>(x[(i + j)]), (2L, (j + 1L), y[((n - 1L) - i)]))));
                }
            }

#line hidden
            QFTImpl.Adjoint.Controlled.Apply((__controlQubits__, y));
#line hidden
            return QVoid.Instance;
        }

        ;
        public override Func<(IQArray<Qubit>,(IQArray<Qubit>,IQArray<Qubit>)), QVoid> ControlledAdjointBody => (__in__) =>
        {
            var (__controlQubits__,(x,y)) = __in__;
#line hidden
            var n = x.Length;
#line hidden
            QFTImpl.Adjoint.Adjoint.Controlled.Apply((__controlQubits__, y));
#line hidden
            foreach (var i in RangeReverse.Apply(new Range(0L, (n - 1L))))
#line hidden
            {
#line hidden
                foreach (var j in RangeReverse.Apply(new Range(0L, ((n - 1L) - i))))
#line hidden
                {
#line hidden
                    MicrosoftQuantumIntrinsicR1Frac.Controlled.Adjoint.Controlled.Apply((__controlQubits__, (new QArray<Qubit>(x[(i + j)]), (2L, (j + 1L), y[((n - 1L) - i)]))));
                }
            }

#line hidden
            QFTImpl.Adjoint.Controlled.Apply((__controlQubits__, y));
#line hidden
            return QVoid.Instance;
        }

        ;
        public override void Init()
        {
            this.Length = this.Factory.Get<ICallable>(typeof(Microsoft.Quantum.Core.Length<>));
            this.RangeReverse = this.Factory.Get<ICallable<Range, Range>>(typeof(Microsoft.Quantum.Core.RangeReverse));
            this.MicrosoftQuantumIntrinsicR1Frac = this.Factory.Get<IUnitary<(Int64,Int64,Qubit)>>(typeof(Microsoft.Quantum.Intrinsic.R1Frac));
            this.QFTImpl = this.Factory.Get<IUnitary<IQArray<Qubit>>>(typeof(QFTImpl));
        }

        public override IApplyData __dataIn((IQArray<Qubit>,IQArray<Qubit>) data) => new In(data);
        public override IApplyData __dataOut(QVoid data) => data;
        public static System.Threading.Tasks.Task<QVoid> Run(IOperationFactory __m__, IQArray<Qubit> x, IQArray<Qubit> y)
        {
            return __m__.Run<QuantumAdd, (IQArray<Qubit>,IQArray<Qubit>), QVoid>((x, y));
        }
    }

    public class TestQuantumAdd : Operation<(Int64,Int64,Int64), Int64>, ICallable
    {
        public TestQuantumAdd(IOperationFactory m) : base(m)
        {
        }

        public class In : QTuple<(Int64,Int64,Int64)>, IApplyData
        {
            public In((Int64,Int64,Int64) data) : base(data)
            {
            }

            System.Collections.Generic.IEnumerable<Qubit> IApplyData.Qubits => null;
        }

        String ICallable.Name => "TestQuantumAdd";
        String ICallable.FullName => "Quantum.QSharpBasicArithmetics.TestQuantumAdd";
        protected ICallable<IQArray<Result>, IQArray<Boolean>> MicrosoftQuantumConvertResultArrayAsBoolArray
        {
            get;
            set;
        }

        protected Allocate Allocate
        {
            get;
            set;
        }

        protected Release Release
        {
            get;
            set;
        }

        protected ICallable<Qubit, QVoid> MicrosoftQuantumIntrinsicReset
        {
            get;
            set;
        }

        protected IUnitary<Qubit> MicrosoftQuantumIntrinsicX
        {
            get;
            set;
        }

        protected ICallable<Qubit, Result> MicrosoftQuantumMeasurementMResetZ
        {
            get;
            set;
        }

        protected IUnitary<(IQArray<Qubit>,IQArray<Qubit>)> QuantumAdd
        {
            get;
            set;
        }

        public override Func<(Int64,Int64,Int64), Int64> Body => (__in__) =>
        {
            var (a,b,n) = __in__;
#line 23 "C:\\Demo\\Quantum-Arithmetic-QSharp\\QSharpBasicArithmetics\\Operations.qs"
            var resultArray = QArray<Result>.Create(n);
#line hidden
            {
#line 25 "C:\\Demo\\Quantum-Arithmetic-QSharp\\QSharpBasicArithmetics\\Operations.qs"
                var (x,y) = (Allocate.Apply(n), Allocate.Apply(n));
#line hidden
                Exception __arg1__ = null;
                try
                {
#line 27 "C:\\Demo\\Quantum-Arithmetic-QSharp\\QSharpBasicArithmetics\\Operations.qs"
                    var array1 = QArray<Boolean>.Create(n);
#line 28 "C:\\Demo\\Quantum-Arithmetic-QSharp\\QSharpBasicArithmetics\\Operations.qs"
                    var tempInt1 = a;
#line 29 "C:\\Demo\\Quantum-Arithmetic-QSharp\\QSharpBasicArithmetics\\Operations.qs"
                    foreach (var idxBit in new Range(0L, (n - 1L)))
#line hidden
                    {
#line 30 "C:\\Demo\\Quantum-Arithmetic-QSharp\\QSharpBasicArithmetics\\Operations.qs"
                        array1.Modify(((n - 1L) - idxBit), (((tempInt1 % 2L) == 0L) ? false : true));
#line 31 "C:\\Demo\\Quantum-Arithmetic-QSharp\\QSharpBasicArithmetics\\Operations.qs"
                        tempInt1 = (tempInt1 / 2L);
                    }

#line 33 "C:\\Demo\\Quantum-Arithmetic-QSharp\\QSharpBasicArithmetics\\Operations.qs"
                    foreach (var idx in new Range(0L, (n - 1L)))
#line hidden
                    {
#line 34 "C:\\Demo\\Quantum-Arithmetic-QSharp\\QSharpBasicArithmetics\\Operations.qs"
                        if (array1[idx])
                        {
#line 35 "C:\\Demo\\Quantum-Arithmetic-QSharp\\QSharpBasicArithmetics\\Operations.qs"
                            MicrosoftQuantumIntrinsicX.Apply(x[idx]);
                        }
                    }

#line 40 "C:\\Demo\\Quantum-Arithmetic-QSharp\\QSharpBasicArithmetics\\Operations.qs"
                    var array2 = QArray<Boolean>.Create(n);
#line 41 "C:\\Demo\\Quantum-Arithmetic-QSharp\\QSharpBasicArithmetics\\Operations.qs"
                    var tempInt2 = b;
#line 42 "C:\\Demo\\Quantum-Arithmetic-QSharp\\QSharpBasicArithmetics\\Operations.qs"
                    foreach (var idxBit in new Range(0L, (n - 1L)))
#line hidden
                    {
#line 43 "C:\\Demo\\Quantum-Arithmetic-QSharp\\QSharpBasicArithmetics\\Operations.qs"
                        array2.Modify(((n - 1L) - idxBit), (((tempInt2 % 2L) == 0L) ? false : true));
#line 44 "C:\\Demo\\Quantum-Arithmetic-QSharp\\QSharpBasicArithmetics\\Operations.qs"
                        tempInt2 = (tempInt2 / 2L);
                    }

#line 46 "C:\\Demo\\Quantum-Arithmetic-QSharp\\QSharpBasicArithmetics\\Operations.qs"
                    foreach (var idx in new Range(0L, (n - 1L)))
#line hidden
                    {
#line 47 "C:\\Demo\\Quantum-Arithmetic-QSharp\\QSharpBasicArithmetics\\Operations.qs"
                        if (array2[idx])
                        {
#line 48 "C:\\Demo\\Quantum-Arithmetic-QSharp\\QSharpBasicArithmetics\\Operations.qs"
                            MicrosoftQuantumIntrinsicX.Apply(y[idx]);
                        }
                    }

#line 53 "C:\\Demo\\Quantum-Arithmetic-QSharp\\QSharpBasicArithmetics\\Operations.qs"
                    QuantumAdd.Apply((x, y));
#line 56 "C:\\Demo\\Quantum-Arithmetic-QSharp\\QSharpBasicArithmetics\\Operations.qs"
                    foreach (var idx in new Range(0L, (n - 1L)))
#line hidden
                    {
#line 57 "C:\\Demo\\Quantum-Arithmetic-QSharp\\QSharpBasicArithmetics\\Operations.qs"
                        resultArray.Modify(idx, MicrosoftQuantumMeasurementMResetZ.Apply(y[idx]));
                    }

#line 59 "C:\\Demo\\Quantum-Arithmetic-QSharp\\QSharpBasicArithmetics\\Operations.qs"
                    foreach (var idx in new Range(0L, (n - 1L)))
#line hidden
                    {
#line 60 "C:\\Demo\\Quantum-Arithmetic-QSharp\\QSharpBasicArithmetics\\Operations.qs"
                        MicrosoftQuantumIntrinsicReset.Apply(x[idx]);
                    }
                }
#line hidden
                catch (Exception __arg2__)
                {
                    __arg1__ = __arg2__;
                    throw __arg1__;
                }
#line hidden
                finally
                {
                    if (__arg1__ != null)
                    {
                        throw __arg1__;
                    }

#line hidden
                    Release.Apply(x);
#line hidden
                    Release.Apply(y);
                }
            }

#line 65 "C:\\Demo\\Quantum-Arithmetic-QSharp\\QSharpBasicArithmetics\\Operations.qs"
            var resultBool = (IQArray<Boolean>)MicrosoftQuantumConvertResultArrayAsBoolArray.Apply(resultArray?.Copy());
#line 66 "C:\\Demo\\Quantum-Arithmetic-QSharp\\QSharpBasicArithmetics\\Operations.qs"
            var resultInt = 0L;
#line 67 "C:\\Demo\\Quantum-Arithmetic-QSharp\\QSharpBasicArithmetics\\Operations.qs"
            foreach (var idx in new Range(0L, (n - 1L)))
#line hidden
            {
#line 68 "C:\\Demo\\Quantum-Arithmetic-QSharp\\QSharpBasicArithmetics\\Operations.qs"
                if (resultBool[idx])
                {
#line 69 "C:\\Demo\\Quantum-Arithmetic-QSharp\\QSharpBasicArithmetics\\Operations.qs"
                    resultInt = (resultInt + 2L.Pow(((n - 1L) - idx)));
                }
            }

#line 72 "C:\\Demo\\Quantum-Arithmetic-QSharp\\QSharpBasicArithmetics\\Operations.qs"
            return resultInt;
        }

        ;
        public override void Init()
        {
            this.MicrosoftQuantumConvertResultArrayAsBoolArray = this.Factory.Get<ICallable<IQArray<Result>, IQArray<Boolean>>>(typeof(Microsoft.Quantum.Convert.ResultArrayAsBoolArray));
            this.Allocate = this.Factory.Get<Allocate>(typeof(Microsoft.Quantum.Intrinsic.Allocate));
            this.Release = this.Factory.Get<Release>(typeof(Microsoft.Quantum.Intrinsic.Release));
            this.MicrosoftQuantumIntrinsicReset = this.Factory.Get<ICallable<Qubit, QVoid>>(typeof(Microsoft.Quantum.Intrinsic.Reset));
            this.MicrosoftQuantumIntrinsicX = this.Factory.Get<IUnitary<Qubit>>(typeof(Microsoft.Quantum.Intrinsic.X));
            this.MicrosoftQuantumMeasurementMResetZ = this.Factory.Get<ICallable<Qubit, Result>>(typeof(Microsoft.Quantum.Measurement.MResetZ));
            this.QuantumAdd = this.Factory.Get<IUnitary<(IQArray<Qubit>,IQArray<Qubit>)>>(typeof(QuantumAdd));
        }

        public override IApplyData __dataIn((Int64,Int64,Int64) data) => new In(data);
        public override IApplyData __dataOut(Int64 data) => new QTuple<Int64>(data);
        public static System.Threading.Tasks.Task<Int64> Run(IOperationFactory __m__, Int64 a, Int64 b, Int64 n)
        {
            return __m__.Run<TestQuantumAdd, (Int64,Int64,Int64), Int64>((a, b, n));
        }
    }

    public class TestQuantumSub : Operation<(Int64,Int64,Int64), Int64>, ICallable
    {
        public TestQuantumSub(IOperationFactory m) : base(m)
        {
        }

        public class In : QTuple<(Int64,Int64,Int64)>, IApplyData
        {
            public In((Int64,Int64,Int64) data) : base(data)
            {
            }

            System.Collections.Generic.IEnumerable<Qubit> IApplyData.Qubits => null;
        }

        String ICallable.Name => "TestQuantumSub";
        String ICallable.FullName => "Quantum.QSharpBasicArithmetics.TestQuantumSub";
        protected ICallable<IQArray<Result>, IQArray<Boolean>> MicrosoftQuantumConvertResultArrayAsBoolArray
        {
            get;
            set;
        }

        protected Allocate Allocate
        {
            get;
            set;
        }

        protected Release Release
        {
            get;
            set;
        }

        protected ICallable<Qubit, QVoid> MicrosoftQuantumIntrinsicReset
        {
            get;
            set;
        }

        protected IUnitary<Qubit> MicrosoftQuantumIntrinsicX
        {
            get;
            set;
        }

        protected ICallable<Qubit, Result> MicrosoftQuantumMeasurementMResetZ
        {
            get;
            set;
        }

        protected IUnitary<(IQArray<Qubit>,IQArray<Qubit>)> QuantumAdd
        {
            get;
            set;
        }

        public override Func<(Int64,Int64,Int64), Int64> Body => (__in__) =>
        {
            var (a,b,n) = __in__;
#line 76 "C:\\Demo\\Quantum-Arithmetic-QSharp\\QSharpBasicArithmetics\\Operations.qs"
            var resultArray = QArray<Result>.Create(n);
#line hidden
            {
#line 78 "C:\\Demo\\Quantum-Arithmetic-QSharp\\QSharpBasicArithmetics\\Operations.qs"
                var (x,y) = (Allocate.Apply(n), Allocate.Apply(n));
#line hidden
                Exception __arg1__ = null;
                try
                {
#line 80 "C:\\Demo\\Quantum-Arithmetic-QSharp\\QSharpBasicArithmetics\\Operations.qs"
                    var array1 = QArray<Boolean>.Create(n);
#line 81 "C:\\Demo\\Quantum-Arithmetic-QSharp\\QSharpBasicArithmetics\\Operations.qs"
                    var tempInt1 = a;
#line 82 "C:\\Demo\\Quantum-Arithmetic-QSharp\\QSharpBasicArithmetics\\Operations.qs"
                    foreach (var idxBit in new Range(0L, (n - 1L)))
#line hidden
                    {
#line 83 "C:\\Demo\\Quantum-Arithmetic-QSharp\\QSharpBasicArithmetics\\Operations.qs"
                        array1.Modify(((n - 1L) - idxBit), (((tempInt1 % 2L) == 0L) ? false : true));
#line 84 "C:\\Demo\\Quantum-Arithmetic-QSharp\\QSharpBasicArithmetics\\Operations.qs"
                        tempInt1 = (tempInt1 / 2L);
                    }

#line 86 "C:\\Demo\\Quantum-Arithmetic-QSharp\\QSharpBasicArithmetics\\Operations.qs"
                    foreach (var idx in new Range(0L, (n - 1L)))
#line hidden
                    {
#line 87 "C:\\Demo\\Quantum-Arithmetic-QSharp\\QSharpBasicArithmetics\\Operations.qs"
                        if (array1[idx])
                        {
#line 88 "C:\\Demo\\Quantum-Arithmetic-QSharp\\QSharpBasicArithmetics\\Operations.qs"
                            MicrosoftQuantumIntrinsicX.Apply(x[idx]);
                        }
                    }

#line 93 "C:\\Demo\\Quantum-Arithmetic-QSharp\\QSharpBasicArithmetics\\Operations.qs"
                    var array2 = QArray<Boolean>.Create(n);
#line 94 "C:\\Demo\\Quantum-Arithmetic-QSharp\\QSharpBasicArithmetics\\Operations.qs"
                    var tempInt2 = b;
#line 95 "C:\\Demo\\Quantum-Arithmetic-QSharp\\QSharpBasicArithmetics\\Operations.qs"
                    foreach (var idxBit in new Range(0L, (n - 1L)))
#line hidden
                    {
#line 96 "C:\\Demo\\Quantum-Arithmetic-QSharp\\QSharpBasicArithmetics\\Operations.qs"
                        array2.Modify(((n - 1L) - idxBit), (((tempInt2 % 2L) == 0L) ? false : true));
#line 97 "C:\\Demo\\Quantum-Arithmetic-QSharp\\QSharpBasicArithmetics\\Operations.qs"
                        tempInt2 = (tempInt2 / 2L);
                    }

#line 99 "C:\\Demo\\Quantum-Arithmetic-QSharp\\QSharpBasicArithmetics\\Operations.qs"
                    foreach (var idx in new Range(0L, (n - 1L)))
#line hidden
                    {
#line 100 "C:\\Demo\\Quantum-Arithmetic-QSharp\\QSharpBasicArithmetics\\Operations.qs"
                        if (array2[idx])
                        {
#line 101 "C:\\Demo\\Quantum-Arithmetic-QSharp\\QSharpBasicArithmetics\\Operations.qs"
                            MicrosoftQuantumIntrinsicX.Apply(y[idx]);
                        }
                    }

#line 106 "C:\\Demo\\Quantum-Arithmetic-QSharp\\QSharpBasicArithmetics\\Operations.qs"
                    QuantumAdd.Adjoint.Apply((x, y));
#line 109 "C:\\Demo\\Quantum-Arithmetic-QSharp\\QSharpBasicArithmetics\\Operations.qs"
                    foreach (var idx in new Range(0L, (n - 1L)))
#line hidden
                    {
#line 110 "C:\\Demo\\Quantum-Arithmetic-QSharp\\QSharpBasicArithmetics\\Operations.qs"
                        resultArray.Modify(idx, MicrosoftQuantumMeasurementMResetZ.Apply(y[idx]));
                    }

#line 112 "C:\\Demo\\Quantum-Arithmetic-QSharp\\QSharpBasicArithmetics\\Operations.qs"
                    foreach (var idx in new Range(0L, (n - 1L)))
#line hidden
                    {
#line 113 "C:\\Demo\\Quantum-Arithmetic-QSharp\\QSharpBasicArithmetics\\Operations.qs"
                        MicrosoftQuantumIntrinsicReset.Apply(x[idx]);
                    }
                }
#line hidden
                catch (Exception __arg2__)
                {
                    __arg1__ = __arg2__;
                    throw __arg1__;
                }
#line hidden
                finally
                {
                    if (__arg1__ != null)
                    {
                        throw __arg1__;
                    }

#line hidden
                    Release.Apply(x);
#line hidden
                    Release.Apply(y);
                }
            }

#line 118 "C:\\Demo\\Quantum-Arithmetic-QSharp\\QSharpBasicArithmetics\\Operations.qs"
            var resultBool = (IQArray<Boolean>)MicrosoftQuantumConvertResultArrayAsBoolArray.Apply(resultArray?.Copy());
#line 119 "C:\\Demo\\Quantum-Arithmetic-QSharp\\QSharpBasicArithmetics\\Operations.qs"
            var resultInt = 0L;
#line 120 "C:\\Demo\\Quantum-Arithmetic-QSharp\\QSharpBasicArithmetics\\Operations.qs"
            foreach (var idx in new Range(0L, (n - 1L)))
#line hidden
            {
#line 121 "C:\\Demo\\Quantum-Arithmetic-QSharp\\QSharpBasicArithmetics\\Operations.qs"
                if (resultBool[idx])
                {
#line 122 "C:\\Demo\\Quantum-Arithmetic-QSharp\\QSharpBasicArithmetics\\Operations.qs"
                    resultInt = (resultInt + 2L.Pow(((n - 1L) - idx)));
                }
            }

#line 125 "C:\\Demo\\Quantum-Arithmetic-QSharp\\QSharpBasicArithmetics\\Operations.qs"
            return resultInt;
        }

        ;
        public override void Init()
        {
            this.MicrosoftQuantumConvertResultArrayAsBoolArray = this.Factory.Get<ICallable<IQArray<Result>, IQArray<Boolean>>>(typeof(Microsoft.Quantum.Convert.ResultArrayAsBoolArray));
            this.Allocate = this.Factory.Get<Allocate>(typeof(Microsoft.Quantum.Intrinsic.Allocate));
            this.Release = this.Factory.Get<Release>(typeof(Microsoft.Quantum.Intrinsic.Release));
            this.MicrosoftQuantumIntrinsicReset = this.Factory.Get<ICallable<Qubit, QVoid>>(typeof(Microsoft.Quantum.Intrinsic.Reset));
            this.MicrosoftQuantumIntrinsicX = this.Factory.Get<IUnitary<Qubit>>(typeof(Microsoft.Quantum.Intrinsic.X));
            this.MicrosoftQuantumMeasurementMResetZ = this.Factory.Get<ICallable<Qubit, Result>>(typeof(Microsoft.Quantum.Measurement.MResetZ));
            this.QuantumAdd = this.Factory.Get<IUnitary<(IQArray<Qubit>,IQArray<Qubit>)>>(typeof(QuantumAdd));
        }

        public override IApplyData __dataIn((Int64,Int64,Int64) data) => new In(data);
        public override IApplyData __dataOut(Int64 data) => new QTuple<Int64>(data);
        public static System.Threading.Tasks.Task<Int64> Run(IOperationFactory __m__, Int64 a, Int64 b, Int64 n)
        {
            return __m__.Run<TestQuantumSub, (Int64,Int64,Int64), Int64>((a, b, n));
        }
    }

    public class QuantumAddByNumber : Unitary<(IQArray<Qubit>,Int64)>, ICallable
    {
        public QuantumAddByNumber(IOperationFactory m) : base(m)
        {
        }

        public class In : QTuple<(IQArray<Qubit>,Int64)>, IApplyData
        {
            public In((IQArray<Qubit>,Int64) data) : base(data)
            {
            }

            System.Collections.Generic.IEnumerable<Qubit> IApplyData.Qubits => ((IApplyData)Data.Item1)?.Qubits;
        }

        String ICallable.Name => "QuantumAddByNumber";
        String ICallable.FullName => "Quantum.QSharpBasicArithmetics.QuantumAddByNumber";
        protected ICallable Length
        {
            get;
            set;
        }

        protected ICallable<Range, Range> RangeReverse
        {
            get;
            set;
        }

        protected IUnitary<(Int64,Int64,Qubit)> MicrosoftQuantumIntrinsicR1Frac
        {
            get;
            set;
        }

        protected IUnitary<IQArray<Qubit>> QFTImpl
        {
            get;
            set;
        }

        public override Func<(IQArray<Qubit>,Int64), QVoid> Body => (__in__) =>
        {
            var (x,b) = __in__;
#line 132 "C:\\Demo\\Quantum-Arithmetic-QSharp\\QSharpBasicArithmetics\\Operations.qs"
            var n = x.Length;
#line 135 "C:\\Demo\\Quantum-Arithmetic-QSharp\\QSharpBasicArithmetics\\Operations.qs"
            QFTImpl.Apply(x);
#line 136 "C:\\Demo\\Quantum-Arithmetic-QSharp\\QSharpBasicArithmetics\\Operations.qs"
            foreach (var i in new Range(0L, (n - 1L)))
#line hidden
            {
#line 137 "C:\\Demo\\Quantum-Arithmetic-QSharp\\QSharpBasicArithmetics\\Operations.qs"
                foreach (var j in new Range(0L, ((n - 1L) - i)))
#line hidden
                {
#line 138 "C:\\Demo\\Quantum-Arithmetic-QSharp\\QSharpBasicArithmetics\\Operations.qs"
                    if (!((((b / 2L.Pow(((n - 1L) - (i + j)))) % 2L) == 0L)))
                    {
#line 139 "C:\\Demo\\Quantum-Arithmetic-QSharp\\QSharpBasicArithmetics\\Operations.qs"
                        MicrosoftQuantumIntrinsicR1Frac.Apply((2L, (j + 1L), x[((n - 1L) - i)]));
                    }
                }
            }

#line 143 "C:\\Demo\\Quantum-Arithmetic-QSharp\\QSharpBasicArithmetics\\Operations.qs"
            QFTImpl.Adjoint.Apply(x);
#line hidden
            return QVoid.Instance;
        }

        ;
        public override Func<(IQArray<Qubit>,Int64), QVoid> AdjointBody => (__in__) =>
        {
            var (x,b) = __in__;
#line hidden
            var n = x.Length;
#line hidden
            QFTImpl.Adjoint.Adjoint.Apply(x);
#line hidden
            foreach (var i in RangeReverse.Apply(new Range(0L, (n - 1L))))
#line hidden
            {
#line hidden
                foreach (var j in RangeReverse.Apply(new Range(0L, ((n - 1L) - i))))
#line hidden
                {
#line hidden
                    if (!((((b / 2L.Pow(((n - 1L) - (i + j)))) % 2L) == 0L)))
                    {
#line hidden
                        MicrosoftQuantumIntrinsicR1Frac.Adjoint.Apply((2L, (j + 1L), x[((n - 1L) - i)]));
                    }
                }
            }

#line hidden
            QFTImpl.Adjoint.Apply(x);
#line hidden
            return QVoid.Instance;
        }

        ;
        public override Func<(IQArray<Qubit>,(IQArray<Qubit>,Int64)), QVoid> ControlledBody => (__in__) =>
        {
            var (__controlQubits__,(x,b)) = __in__;
#line hidden
            var n = x.Length;
#line hidden
            QFTImpl.Controlled.Apply((__controlQubits__, x));
#line hidden
            foreach (var i in new Range(0L, (n - 1L)))
#line hidden
            {
#line hidden
                foreach (var j in new Range(0L, ((n - 1L) - i)))
#line hidden
                {
#line hidden
                    if (!((((b / 2L.Pow(((n - 1L) - (i + j)))) % 2L) == 0L)))
                    {
#line hidden
                        MicrosoftQuantumIntrinsicR1Frac.Controlled.Apply((__controlQubits__, (2L, (j + 1L), x[((n - 1L) - i)])));
                    }
                }
            }

#line hidden
            QFTImpl.Adjoint.Controlled.Apply((__controlQubits__, x));
#line hidden
            return QVoid.Instance;
        }

        ;
        public override Func<(IQArray<Qubit>,(IQArray<Qubit>,Int64)), QVoid> ControlledAdjointBody => (__in__) =>
        {
            var (__controlQubits__,(x,b)) = __in__;
#line hidden
            var n = x.Length;
#line hidden
            QFTImpl.Adjoint.Adjoint.Controlled.Apply((__controlQubits__, x));
#line hidden
            foreach (var i in RangeReverse.Apply(new Range(0L, (n - 1L))))
#line hidden
            {
#line hidden
                foreach (var j in RangeReverse.Apply(new Range(0L, ((n - 1L) - i))))
#line hidden
                {
#line hidden
                    if (!((((b / 2L.Pow(((n - 1L) - (i + j)))) % 2L) == 0L)))
                    {
#line hidden
                        MicrosoftQuantumIntrinsicR1Frac.Adjoint.Controlled.Apply((__controlQubits__, (2L, (j + 1L), x[((n - 1L) - i)])));
                    }
                }
            }

#line hidden
            QFTImpl.Adjoint.Controlled.Apply((__controlQubits__, x));
#line hidden
            return QVoid.Instance;
        }

        ;
        public override void Init()
        {
            this.Length = this.Factory.Get<ICallable>(typeof(Microsoft.Quantum.Core.Length<>));
            this.RangeReverse = this.Factory.Get<ICallable<Range, Range>>(typeof(Microsoft.Quantum.Core.RangeReverse));
            this.MicrosoftQuantumIntrinsicR1Frac = this.Factory.Get<IUnitary<(Int64,Int64,Qubit)>>(typeof(Microsoft.Quantum.Intrinsic.R1Frac));
            this.QFTImpl = this.Factory.Get<IUnitary<IQArray<Qubit>>>(typeof(QFTImpl));
        }

        public override IApplyData __dataIn((IQArray<Qubit>,Int64) data) => new In(data);
        public override IApplyData __dataOut(QVoid data) => data;
        public static System.Threading.Tasks.Task<QVoid> Run(IOperationFactory __m__, IQArray<Qubit> x, Int64 b)
        {
            return __m__.Run<QuantumAddByNumber, (IQArray<Qubit>,Int64), QVoid>((x, b));
        }
    }

    public class TestQuantumAddByNumber : Operation<(Int64,Int64,Int64), Int64>, ICallable
    {
        public TestQuantumAddByNumber(IOperationFactory m) : base(m)
        {
        }

        public class In : QTuple<(Int64,Int64,Int64)>, IApplyData
        {
            public In((Int64,Int64,Int64) data) : base(data)
            {
            }

            System.Collections.Generic.IEnumerable<Qubit> IApplyData.Qubits => null;
        }

        String ICallable.Name => "TestQuantumAddByNumber";
        String ICallable.FullName => "Quantum.QSharpBasicArithmetics.TestQuantumAddByNumber";
        protected ICallable<IQArray<Result>, IQArray<Boolean>> MicrosoftQuantumConvertResultArrayAsBoolArray
        {
            get;
            set;
        }

        protected Allocate Allocate
        {
            get;
            set;
        }

        protected Release Release
        {
            get;
            set;
        }

        protected IUnitary<Qubit> MicrosoftQuantumIntrinsicX
        {
            get;
            set;
        }

        protected ICallable<Qubit, Result> MicrosoftQuantumMeasurementMResetZ
        {
            get;
            set;
        }

        protected IUnitary<(IQArray<Qubit>,Int64)> QuantumAddByNumber
        {
            get;
            set;
        }

        public override Func<(Int64,Int64,Int64), Int64> Body => (__in__) =>
        {
            var (a,b,n) = __in__;
#line 147 "C:\\Demo\\Quantum-Arithmetic-QSharp\\QSharpBasicArithmetics\\Operations.qs"
            var resultArray = QArray<Result>.Create(n);
#line hidden
            {
#line 149 "C:\\Demo\\Quantum-Arithmetic-QSharp\\QSharpBasicArithmetics\\Operations.qs"
                var x = Allocate.Apply(n);
#line hidden
                Exception __arg1__ = null;
                try
                {
#line 151 "C:\\Demo\\Quantum-Arithmetic-QSharp\\QSharpBasicArithmetics\\Operations.qs"
                    var array1 = QArray<Boolean>.Create(n);
#line 152 "C:\\Demo\\Quantum-Arithmetic-QSharp\\QSharpBasicArithmetics\\Operations.qs"
                    var tempInt1 = a;
#line 153 "C:\\Demo\\Quantum-Arithmetic-QSharp\\QSharpBasicArithmetics\\Operations.qs"
                    foreach (var idxBit in new Range(0L, (n - 1L)))
#line hidden
                    {
#line 154 "C:\\Demo\\Quantum-Arithmetic-QSharp\\QSharpBasicArithmetics\\Operations.qs"
                        array1.Modify(((n - 1L) - idxBit), (((tempInt1 % 2L) == 0L) ? false : true));
#line 155 "C:\\Demo\\Quantum-Arithmetic-QSharp\\QSharpBasicArithmetics\\Operations.qs"
                        tempInt1 = (tempInt1 / 2L);
                    }

#line 157 "C:\\Demo\\Quantum-Arithmetic-QSharp\\QSharpBasicArithmetics\\Operations.qs"
                    foreach (var idx in new Range(0L, (n - 1L)))
#line hidden
                    {
#line 158 "C:\\Demo\\Quantum-Arithmetic-QSharp\\QSharpBasicArithmetics\\Operations.qs"
                        if (array1[idx])
                        {
#line 159 "C:\\Demo\\Quantum-Arithmetic-QSharp\\QSharpBasicArithmetics\\Operations.qs"
                            MicrosoftQuantumIntrinsicX.Apply(x[idx]);
                        }
                    }

#line 164 "C:\\Demo\\Quantum-Arithmetic-QSharp\\QSharpBasicArithmetics\\Operations.qs"
                    QuantumAddByNumber.Apply((x, b));
#line 167 "C:\\Demo\\Quantum-Arithmetic-QSharp\\QSharpBasicArithmetics\\Operations.qs"
                    foreach (var idx in new Range(0L, (n - 1L)))
#line hidden
                    {
#line 168 "C:\\Demo\\Quantum-Arithmetic-QSharp\\QSharpBasicArithmetics\\Operations.qs"
                        resultArray.Modify(idx, MicrosoftQuantumMeasurementMResetZ.Apply(x[idx]));
                    }
                }
#line hidden
                catch (Exception __arg2__)
                {
                    __arg1__ = __arg2__;
                    throw __arg1__;
                }
#line hidden
                finally
                {
                    if (__arg1__ != null)
                    {
                        throw __arg1__;
                    }

#line hidden
                    Release.Apply(x);
                }
            }

#line 173 "C:\\Demo\\Quantum-Arithmetic-QSharp\\QSharpBasicArithmetics\\Operations.qs"
            var resultBool = (IQArray<Boolean>)MicrosoftQuantumConvertResultArrayAsBoolArray.Apply(resultArray?.Copy());
#line 174 "C:\\Demo\\Quantum-Arithmetic-QSharp\\QSharpBasicArithmetics\\Operations.qs"
            var resultInt = 0L;
#line 175 "C:\\Demo\\Quantum-Arithmetic-QSharp\\QSharpBasicArithmetics\\Operations.qs"
            foreach (var idx in new Range(0L, (n - 1L)))
#line hidden
            {
#line 176 "C:\\Demo\\Quantum-Arithmetic-QSharp\\QSharpBasicArithmetics\\Operations.qs"
                if (resultBool[idx])
                {
#line 177 "C:\\Demo\\Quantum-Arithmetic-QSharp\\QSharpBasicArithmetics\\Operations.qs"
                    resultInt = (resultInt + 2L.Pow(((n - 1L) - idx)));
                }
            }

#line 180 "C:\\Demo\\Quantum-Arithmetic-QSharp\\QSharpBasicArithmetics\\Operations.qs"
            return resultInt;
        }

        ;
        public override void Init()
        {
            this.MicrosoftQuantumConvertResultArrayAsBoolArray = this.Factory.Get<ICallable<IQArray<Result>, IQArray<Boolean>>>(typeof(Microsoft.Quantum.Convert.ResultArrayAsBoolArray));
            this.Allocate = this.Factory.Get<Allocate>(typeof(Microsoft.Quantum.Intrinsic.Allocate));
            this.Release = this.Factory.Get<Release>(typeof(Microsoft.Quantum.Intrinsic.Release));
            this.MicrosoftQuantumIntrinsicX = this.Factory.Get<IUnitary<Qubit>>(typeof(Microsoft.Quantum.Intrinsic.X));
            this.MicrosoftQuantumMeasurementMResetZ = this.Factory.Get<ICallable<Qubit, Result>>(typeof(Microsoft.Quantum.Measurement.MResetZ));
            this.QuantumAddByNumber = this.Factory.Get<IUnitary<(IQArray<Qubit>,Int64)>>(typeof(QuantumAddByNumber));
        }

        public override IApplyData __dataIn((Int64,Int64,Int64) data) => new In(data);
        public override IApplyData __dataOut(Int64 data) => new QTuple<Int64>(data);
        public static System.Threading.Tasks.Task<Int64> Run(IOperationFactory __m__, Int64 a, Int64 b, Int64 n)
        {
            return __m__.Run<TestQuantumAddByNumber, (Int64,Int64,Int64), Int64>((a, b, n));
        }
    }

    public class QuantumMultiply : Unitary<(Int64,IQArray<Qubit>)>, ICallable
    {
        public QuantumMultiply(IOperationFactory m) : base(m)
        {
        }

        public class In : QTuple<(Int64,IQArray<Qubit>)>, IApplyData
        {
            public In((Int64,IQArray<Qubit>) data) : base(data)
            {
            }

            System.Collections.Generic.IEnumerable<Qubit> IApplyData.Qubits => ((IApplyData)Data.Item2)?.Qubits;
        }

        String ICallable.Name => "QuantumMultiply";
        String ICallable.FullName => "Quantum.QSharpBasicArithmetics.QuantumMultiply";
        protected ICallable MicrosoftQuantumArraysZip
        {
            get;
            set;
        }

        protected IUnitary MicrosoftQuantumCanonApplyToEachCA
        {
            get;
            set;
        }

        protected ICallable Length
        {
            get;
            set;
        }

        protected ICallable<Range, Range> RangeReverse
        {
            get;
            set;
        }

        protected Allocate Allocate
        {
            get;
            set;
        }

        protected Release Release
        {
            get;
            set;
        }

        protected IUnitary<(Qubit,Qubit)> MicrosoftQuantumIntrinsicSWAP
        {
            get;
            set;
        }

        protected ICallable<(Int64,Int64), Int64> MicrosoftQuantumMathInverseModI
        {
            get;
            set;
        }

        protected IUnitary<(IQArray<Qubit>,IQArray<Qubit>)> QuantumAdd
        {
            get;
            set;
        }

        public override Func<(Int64,IQArray<Qubit>), QVoid> Body => (__in__) =>
        {
            var (a,y) = __in__;
#line 191 "C:\\Demo\\Quantum-Arithmetic-QSharp\\QSharpBasicArithmetics\\Operations.qs"
            var n = y.Length;
#line 192 "C:\\Demo\\Quantum-Arithmetic-QSharp\\QSharpBasicArithmetics\\Operations.qs"
            var a_mod = (a % 2L.Pow(n));
#line hidden
            {
#line 194 "C:\\Demo\\Quantum-Arithmetic-QSharp\\QSharpBasicArithmetics\\Operations.qs"
                var s = Allocate.Apply(n);
#line hidden
                Exception __arg1__ = null;
                try
                {
#line 198 "C:\\Demo\\Quantum-Arithmetic-QSharp\\QSharpBasicArithmetics\\Operations.qs"
                    foreach (var r in new Range(0L, (a_mod - 1L)))
#line hidden
                    {
#line 199 "C:\\Demo\\Quantum-Arithmetic-QSharp\\QSharpBasicArithmetics\\Operations.qs"
                        QuantumAdd.Apply((y, s));
                    }

#line 204 "C:\\Demo\\Quantum-Arithmetic-QSharp\\QSharpBasicArithmetics\\Operations.qs"
                    MicrosoftQuantumCanonApplyToEachCA.Apply((MicrosoftQuantumIntrinsicSWAP, MicrosoftQuantumArraysZip.Apply<IQArray<(Qubit,Qubit)>>((y, s))));
#line 209 "C:\\Demo\\Quantum-Arithmetic-QSharp\\QSharpBasicArithmetics\\Operations.qs"
                    var a_inv = MicrosoftQuantumMathInverseModI.Apply((a_mod, 2L.Pow(n)));
#line 210 "C:\\Demo\\Quantum-Arithmetic-QSharp\\QSharpBasicArithmetics\\Operations.qs"
                    foreach (var r in new Range(0L, (a_inv - 1L)))
#line hidden
                    {
#line 211 "C:\\Demo\\Quantum-Arithmetic-QSharp\\QSharpBasicArithmetics\\Operations.qs"
                        QuantumAdd.Adjoint.Apply((y, s));
                    }
                }
#line hidden
                catch (Exception __arg2__)
                {
                    __arg1__ = __arg2__;
                    throw __arg1__;
                }
#line hidden
                finally
                {
                    if (__arg1__ != null)
                    {
                        throw __arg1__;
                    }

#line hidden
                    Release.Apply(s);
                }
            }

#line hidden
            return QVoid.Instance;
        }

        ;
        public override Func<(Int64,IQArray<Qubit>), QVoid> AdjointBody => (__in__) =>
        {
            var (a,y) = __in__;
#line hidden
            var n = y.Length;
#line hidden
            var a_mod = (a % 2L.Pow(n));
#line hidden
            {
#line hidden
                var s = Allocate.Apply(n);
#line hidden
                Exception __arg1__ = null;
                try
                {
#line hidden
                    var a_inv = MicrosoftQuantumMathInverseModI.Apply((a_mod, 2L.Pow(n)));
#line hidden
                    foreach (var r in RangeReverse.Apply(new Range(0L, (a_inv - 1L))))
#line hidden
                    {
#line hidden
                        QuantumAdd.Adjoint.Adjoint.Apply((y, s));
                    }

#line hidden
                    MicrosoftQuantumCanonApplyToEachCA.Adjoint.Apply((MicrosoftQuantumIntrinsicSWAP, MicrosoftQuantumArraysZip.Apply<IQArray<(Qubit,Qubit)>>((y, s))));
#line hidden
                    foreach (var r in RangeReverse.Apply(new Range(0L, (a_mod - 1L))))
#line hidden
                    {
#line hidden
                        QuantumAdd.Adjoint.Apply((y, s));
                    }
                }
#line hidden
                catch (Exception __arg2__)
                {
                    __arg1__ = __arg2__;
                    throw __arg1__;
                }
#line hidden
                finally
                {
                    if (__arg1__ != null)
                    {
                        throw __arg1__;
                    }

#line hidden
                    Release.Apply(s);
                }
            }

#line hidden
            return QVoid.Instance;
        }

        ;
        public override Func<(IQArray<Qubit>,(Int64,IQArray<Qubit>)), QVoid> ControlledBody => (__in__) =>
        {
            var (__controlQubits__,(a,y)) = __in__;
#line hidden
            var n = y.Length;
#line hidden
            var a_mod = (a % 2L.Pow(n));
#line hidden
            {
#line hidden
                var s = Allocate.Apply(n);
#line hidden
                Exception __arg1__ = null;
                try
                {
#line hidden
                    foreach (var r in new Range(0L, (a_mod - 1L)))
#line hidden
                    {
#line hidden
                        QuantumAdd.Controlled.Apply((__controlQubits__, (y, s)));
                    }

#line hidden
                    MicrosoftQuantumCanonApplyToEachCA.Controlled.Apply((__controlQubits__, (MicrosoftQuantumIntrinsicSWAP, MicrosoftQuantumArraysZip.Apply<IQArray<(Qubit,Qubit)>>((y, s)))));
#line hidden
                    var a_inv = MicrosoftQuantumMathInverseModI.Apply((a_mod, 2L.Pow(n)));
#line hidden
                    foreach (var r in new Range(0L, (a_inv - 1L)))
#line hidden
                    {
#line hidden
                        QuantumAdd.Adjoint.Controlled.Apply((__controlQubits__, (y, s)));
                    }
                }
#line hidden
                catch (Exception __arg2__)
                {
                    __arg1__ = __arg2__;
                    throw __arg1__;
                }
#line hidden
                finally
                {
                    if (__arg1__ != null)
                    {
                        throw __arg1__;
                    }

#line hidden
                    Release.Apply(s);
                }
            }

#line hidden
            return QVoid.Instance;
        }

        ;
        public override Func<(IQArray<Qubit>,(Int64,IQArray<Qubit>)), QVoid> ControlledAdjointBody => (__in__) =>
        {
            var (__controlQubits__,(a,y)) = __in__;
#line hidden
            var n = y.Length;
#line hidden
            var a_mod = (a % 2L.Pow(n));
#line hidden
            {
#line hidden
                var s = Allocate.Apply(n);
#line hidden
                Exception __arg1__ = null;
                try
                {
#line hidden
                    var a_inv = MicrosoftQuantumMathInverseModI.Apply((a_mod, 2L.Pow(n)));
#line hidden
                    foreach (var r in RangeReverse.Apply(new Range(0L, (a_inv - 1L))))
#line hidden
                    {
#line hidden
                        QuantumAdd.Adjoint.Adjoint.Controlled.Apply((__controlQubits__, (y, s)));
                    }

#line hidden
                    MicrosoftQuantumCanonApplyToEachCA.Adjoint.Controlled.Apply((__controlQubits__, (MicrosoftQuantumIntrinsicSWAP, MicrosoftQuantumArraysZip.Apply<IQArray<(Qubit,Qubit)>>((y, s)))));
#line hidden
                    foreach (var r in RangeReverse.Apply(new Range(0L, (a_mod - 1L))))
#line hidden
                    {
#line hidden
                        QuantumAdd.Adjoint.Controlled.Apply((__controlQubits__, (y, s)));
                    }
                }
#line hidden
                catch (Exception __arg2__)
                {
                    __arg1__ = __arg2__;
                    throw __arg1__;
                }
#line hidden
                finally
                {
                    if (__arg1__ != null)
                    {
                        throw __arg1__;
                    }

#line hidden
                    Release.Apply(s);
                }
            }

#line hidden
            return QVoid.Instance;
        }

        ;
        public override void Init()
        {
            this.MicrosoftQuantumArraysZip = this.Factory.Get<ICallable>(typeof(Microsoft.Quantum.Arrays.Zip<,>));
            this.MicrosoftQuantumCanonApplyToEachCA = this.Factory.Get<IUnitary>(typeof(Microsoft.Quantum.Canon.ApplyToEachCA<>));
            this.Length = this.Factory.Get<ICallable>(typeof(Microsoft.Quantum.Core.Length<>));
            this.RangeReverse = this.Factory.Get<ICallable<Range, Range>>(typeof(Microsoft.Quantum.Core.RangeReverse));
            this.Allocate = this.Factory.Get<Allocate>(typeof(Microsoft.Quantum.Intrinsic.Allocate));
            this.Release = this.Factory.Get<Release>(typeof(Microsoft.Quantum.Intrinsic.Release));
            this.MicrosoftQuantumIntrinsicSWAP = this.Factory.Get<IUnitary<(Qubit,Qubit)>>(typeof(Microsoft.Quantum.Intrinsic.SWAP));
            this.MicrosoftQuantumMathInverseModI = this.Factory.Get<ICallable<(Int64,Int64), Int64>>(typeof(Microsoft.Quantum.Math.InverseModI));
            this.QuantumAdd = this.Factory.Get<IUnitary<(IQArray<Qubit>,IQArray<Qubit>)>>(typeof(QuantumAdd));
        }

        public override IApplyData __dataIn((Int64,IQArray<Qubit>) data) => new In(data);
        public override IApplyData __dataOut(QVoid data) => data;
        public static System.Threading.Tasks.Task<QVoid> Run(IOperationFactory __m__, Int64 a, IQArray<Qubit> y)
        {
            return __m__.Run<QuantumMultiply, (Int64,IQArray<Qubit>), QVoid>((a, y));
        }
    }

    public class TestQuantumMultiply : Operation<(Int64,Int64,Int64), Int64>, ICallable
    {
        public TestQuantumMultiply(IOperationFactory m) : base(m)
        {
        }

        public class In : QTuple<(Int64,Int64,Int64)>, IApplyData
        {
            public In((Int64,Int64,Int64) data) : base(data)
            {
            }

            System.Collections.Generic.IEnumerable<Qubit> IApplyData.Qubits => null;
        }

        String ICallable.Name => "TestQuantumMultiply";
        String ICallable.FullName => "Quantum.QSharpBasicArithmetics.TestQuantumMultiply";
        protected ICallable<IQArray<Result>, IQArray<Boolean>> MicrosoftQuantumConvertResultArrayAsBoolArray
        {
            get;
            set;
        }

        protected Allocate Allocate
        {
            get;
            set;
        }

        protected Release Release
        {
            get;
            set;
        }

        protected IUnitary<Qubit> MicrosoftQuantumIntrinsicX
        {
            get;
            set;
        }

        protected ICallable<Qubit, Result> MicrosoftQuantumMeasurementMResetZ
        {
            get;
            set;
        }

        protected IUnitary<(Int64,IQArray<Qubit>)> QuantumMultiply
        {
            get;
            set;
        }

        public override Func<(Int64,Int64,Int64), Int64> Body => (__in__) =>
        {
            var (a,b,n) = __in__;
#line 217 "C:\\Demo\\Quantum-Arithmetic-QSharp\\QSharpBasicArithmetics\\Operations.qs"
            var resultArray = QArray<Result>.Create(n);
#line hidden
            {
#line 219 "C:\\Demo\\Quantum-Arithmetic-QSharp\\QSharpBasicArithmetics\\Operations.qs"
                var y = Allocate.Apply(n);
#line hidden
                Exception __arg1__ = null;
                try
                {
#line 221 "C:\\Demo\\Quantum-Arithmetic-QSharp\\QSharpBasicArithmetics\\Operations.qs"
                    var array2 = QArray<Boolean>.Create(n);
#line 222 "C:\\Demo\\Quantum-Arithmetic-QSharp\\QSharpBasicArithmetics\\Operations.qs"
                    var tempInt2 = b;
#line 223 "C:\\Demo\\Quantum-Arithmetic-QSharp\\QSharpBasicArithmetics\\Operations.qs"
                    foreach (var idxBit in new Range(0L, (n - 1L)))
#line hidden
                    {
#line 224 "C:\\Demo\\Quantum-Arithmetic-QSharp\\QSharpBasicArithmetics\\Operations.qs"
                        array2.Modify(((n - 1L) - idxBit), (((tempInt2 % 2L) == 0L) ? false : true));
#line 225 "C:\\Demo\\Quantum-Arithmetic-QSharp\\QSharpBasicArithmetics\\Operations.qs"
                        tempInt2 = (tempInt2 / 2L);
                    }

#line 227 "C:\\Demo\\Quantum-Arithmetic-QSharp\\QSharpBasicArithmetics\\Operations.qs"
                    foreach (var idx in new Range(0L, (n - 1L)))
#line hidden
                    {
#line 228 "C:\\Demo\\Quantum-Arithmetic-QSharp\\QSharpBasicArithmetics\\Operations.qs"
                        if (array2[idx])
                        {
#line 229 "C:\\Demo\\Quantum-Arithmetic-QSharp\\QSharpBasicArithmetics\\Operations.qs"
                            MicrosoftQuantumIntrinsicX.Apply(y[idx]);
                        }
                    }

#line 234 "C:\\Demo\\Quantum-Arithmetic-QSharp\\QSharpBasicArithmetics\\Operations.qs"
                    QuantumMultiply.Apply((a, y));
#line 237 "C:\\Demo\\Quantum-Arithmetic-QSharp\\QSharpBasicArithmetics\\Operations.qs"
                    foreach (var idx in new Range(0L, (n - 1L)))
#line hidden
                    {
#line 238 "C:\\Demo\\Quantum-Arithmetic-QSharp\\QSharpBasicArithmetics\\Operations.qs"
                        resultArray.Modify(idx, MicrosoftQuantumMeasurementMResetZ.Apply(y[idx]));
                    }
                }
#line hidden
                catch (Exception __arg2__)
                {
                    __arg1__ = __arg2__;
                    throw __arg1__;
                }
#line hidden
                finally
                {
                    if (__arg1__ != null)
                    {
                        throw __arg1__;
                    }

#line hidden
                    Release.Apply(y);
                }
            }

#line 243 "C:\\Demo\\Quantum-Arithmetic-QSharp\\QSharpBasicArithmetics\\Operations.qs"
            var resultBool = (IQArray<Boolean>)MicrosoftQuantumConvertResultArrayAsBoolArray.Apply(resultArray?.Copy());
#line 244 "C:\\Demo\\Quantum-Arithmetic-QSharp\\QSharpBasicArithmetics\\Operations.qs"
            var resultInt = 0L;
#line 245 "C:\\Demo\\Quantum-Arithmetic-QSharp\\QSharpBasicArithmetics\\Operations.qs"
            foreach (var idx in new Range(0L, (n - 1L)))
#line hidden
            {
#line 246 "C:\\Demo\\Quantum-Arithmetic-QSharp\\QSharpBasicArithmetics\\Operations.qs"
                if (resultBool[idx])
                {
#line 247 "C:\\Demo\\Quantum-Arithmetic-QSharp\\QSharpBasicArithmetics\\Operations.qs"
                    resultInt = (resultInt + 2L.Pow(((n - 1L) - idx)));
                }
            }

#line 250 "C:\\Demo\\Quantum-Arithmetic-QSharp\\QSharpBasicArithmetics\\Operations.qs"
            return resultInt;
        }

        ;
        public override void Init()
        {
            this.MicrosoftQuantumConvertResultArrayAsBoolArray = this.Factory.Get<ICallable<IQArray<Result>, IQArray<Boolean>>>(typeof(Microsoft.Quantum.Convert.ResultArrayAsBoolArray));
            this.Allocate = this.Factory.Get<Allocate>(typeof(Microsoft.Quantum.Intrinsic.Allocate));
            this.Release = this.Factory.Get<Release>(typeof(Microsoft.Quantum.Intrinsic.Release));
            this.MicrosoftQuantumIntrinsicX = this.Factory.Get<IUnitary<Qubit>>(typeof(Microsoft.Quantum.Intrinsic.X));
            this.MicrosoftQuantumMeasurementMResetZ = this.Factory.Get<ICallable<Qubit, Result>>(typeof(Microsoft.Quantum.Measurement.MResetZ));
            this.QuantumMultiply = this.Factory.Get<IUnitary<(Int64,IQArray<Qubit>)>>(typeof(QuantumMultiply));
        }

        public override IApplyData __dataIn((Int64,Int64,Int64) data) => new In(data);
        public override IApplyData __dataOut(Int64 data) => new QTuple<Int64>(data);
        public static System.Threading.Tasks.Task<Int64> Run(IOperationFactory __m__, Int64 a, Int64 b, Int64 n)
        {
            return __m__.Run<TestQuantumMultiply, (Int64,Int64,Int64), Int64>((a, b, n));
        }
    }

    public class QuantumExponent : Operation<(Int64,IQArray<Qubit>), QVoid>, ICallable
    {
        public QuantumExponent(IOperationFactory m) : base(m)
        {
        }

        public class In : QTuple<(Int64,IQArray<Qubit>)>, IApplyData
        {
            public In((Int64,IQArray<Qubit>) data) : base(data)
            {
            }

            System.Collections.Generic.IEnumerable<Qubit> IApplyData.Qubits => ((IApplyData)Data.Item2)?.Qubits;
        }

        String ICallable.Name => "QuantumExponent";
        String ICallable.FullName => "Quantum.QSharpBasicArithmetics.QuantumExponent";
        protected ICallable MicrosoftQuantumArraysZip
        {
            get;
            set;
        }

        protected IUnitary MicrosoftQuantumCanonApplyToEachCA
        {
            get;
            set;
        }

        protected ICallable Length
        {
            get;
            set;
        }

        protected Allocate Allocate
        {
            get;
            set;
        }

        protected Release Release
        {
            get;
            set;
        }

        protected ICallable<Qubit, QVoid> MicrosoftQuantumIntrinsicReset
        {
            get;
            set;
        }

        protected IUnitary<(Qubit,Qubit)> MicrosoftQuantumIntrinsicSWAP
        {
            get;
            set;
        }

        protected IUnitary<Qubit> MicrosoftQuantumIntrinsicX
        {
            get;
            set;
        }

        protected IUnitary<(Int64,IQArray<Qubit>)> QuantumMultiply
        {
            get;
            set;
        }

        public override Func<(Int64,IQArray<Qubit>), QVoid> Body => (__in__) =>
        {
            var (a,x) = __in__;
#line 261 "C:\\Demo\\Quantum-Arithmetic-QSharp\\QSharpBasicArithmetics\\Operations.qs"
            var n = x.Length;
#line hidden
            {
#line 262 "C:\\Demo\\Quantum-Arithmetic-QSharp\\QSharpBasicArithmetics\\Operations.qs"
                var s = Allocate.Apply(n);
#line hidden
                Exception __arg1__ = null;
                try
                {
#line 264 "C:\\Demo\\Quantum-Arithmetic-QSharp\\QSharpBasicArithmetics\\Operations.qs"
                    MicrosoftQuantumIntrinsicX.Apply(s[(n - 1L)]);
#line 267 "C:\\Demo\\Quantum-Arithmetic-QSharp\\QSharpBasicArithmetics\\Operations.qs"
                    foreach (var idx in new Range(0L, (n - 1L)))
#line hidden
                    {
#line 268 "C:\\Demo\\Quantum-Arithmetic-QSharp\\QSharpBasicArithmetics\\Operations.qs"
                        QuantumMultiply.Controlled.Apply((new QArray<Qubit>(x[idx]), (a.Pow(2L.Pow(((n - 1L) - idx))), s)));
                    }

#line 272 "C:\\Demo\\Quantum-Arithmetic-QSharp\\QSharpBasicArithmetics\\Operations.qs"
                    MicrosoftQuantumCanonApplyToEachCA.Apply((MicrosoftQuantumIntrinsicSWAP, MicrosoftQuantumArraysZip.Apply<IQArray<(Qubit,Qubit)>>((x, s))));
#line 275 "C:\\Demo\\Quantum-Arithmetic-QSharp\\QSharpBasicArithmetics\\Operations.qs"
                    foreach (var idx in new Range(0L, (n - 1L)))
#line hidden
                    {
#line 276 "C:\\Demo\\Quantum-Arithmetic-QSharp\\QSharpBasicArithmetics\\Operations.qs"
                        MicrosoftQuantumIntrinsicReset.Apply(s[idx]);
                    }
                }
#line hidden
                catch (Exception __arg2__)
                {
                    __arg1__ = __arg2__;
                    throw __arg1__;
                }
#line hidden
                finally
                {
                    if (__arg1__ != null)
                    {
                        throw __arg1__;
                    }

#line hidden
                    Release.Apply(s);
                }
            }

#line hidden
            return QVoid.Instance;
        }

        ;
        public override void Init()
        {
            this.MicrosoftQuantumArraysZip = this.Factory.Get<ICallable>(typeof(Microsoft.Quantum.Arrays.Zip<,>));
            this.MicrosoftQuantumCanonApplyToEachCA = this.Factory.Get<IUnitary>(typeof(Microsoft.Quantum.Canon.ApplyToEachCA<>));
            this.Length = this.Factory.Get<ICallable>(typeof(Microsoft.Quantum.Core.Length<>));
            this.Allocate = this.Factory.Get<Allocate>(typeof(Microsoft.Quantum.Intrinsic.Allocate));
            this.Release = this.Factory.Get<Release>(typeof(Microsoft.Quantum.Intrinsic.Release));
            this.MicrosoftQuantumIntrinsicReset = this.Factory.Get<ICallable<Qubit, QVoid>>(typeof(Microsoft.Quantum.Intrinsic.Reset));
            this.MicrosoftQuantumIntrinsicSWAP = this.Factory.Get<IUnitary<(Qubit,Qubit)>>(typeof(Microsoft.Quantum.Intrinsic.SWAP));
            this.MicrosoftQuantumIntrinsicX = this.Factory.Get<IUnitary<Qubit>>(typeof(Microsoft.Quantum.Intrinsic.X));
            this.QuantumMultiply = this.Factory.Get<IUnitary<(Int64,IQArray<Qubit>)>>(typeof(QuantumMultiply));
        }

        public override IApplyData __dataIn((Int64,IQArray<Qubit>) data) => new In(data);
        public override IApplyData __dataOut(QVoid data) => data;
        public static System.Threading.Tasks.Task<QVoid> Run(IOperationFactory __m__, Int64 a, IQArray<Qubit> x)
        {
            return __m__.Run<QuantumExponent, (Int64,IQArray<Qubit>), QVoid>((a, x));
        }
    }

    public class TestQuantumExponent : Operation<(Int64,Int64,Int64), Int64>, ICallable
    {
        public TestQuantumExponent(IOperationFactory m) : base(m)
        {
        }

        public class In : QTuple<(Int64,Int64,Int64)>, IApplyData
        {
            public In((Int64,Int64,Int64) data) : base(data)
            {
            }

            System.Collections.Generic.IEnumerable<Qubit> IApplyData.Qubits => null;
        }

        String ICallable.Name => "TestQuantumExponent";
        String ICallable.FullName => "Quantum.QSharpBasicArithmetics.TestQuantumExponent";
        protected ICallable<IQArray<Result>, IQArray<Boolean>> MicrosoftQuantumConvertResultArrayAsBoolArray
        {
            get;
            set;
        }

        protected Allocate Allocate
        {
            get;
            set;
        }

        protected Release Release
        {
            get;
            set;
        }

        protected IUnitary<Qubit> MicrosoftQuantumIntrinsicX
        {
            get;
            set;
        }

        protected ICallable<Qubit, Result> MicrosoftQuantumMeasurementMResetZ
        {
            get;
            set;
        }

        protected ICallable<(Int64,IQArray<Qubit>), QVoid> QuantumExponent
        {
            get;
            set;
        }

        public override Func<(Int64,Int64,Int64), Int64> Body => (__in__) =>
        {
            var (a,b,n) = __in__;
#line 282 "C:\\Demo\\Quantum-Arithmetic-QSharp\\QSharpBasicArithmetics\\Operations.qs"
            var resultArray = QArray<Result>.Create(n);
#line hidden
            {
#line 284 "C:\\Demo\\Quantum-Arithmetic-QSharp\\QSharpBasicArithmetics\\Operations.qs"
                var x = Allocate.Apply(n);
#line hidden
                Exception __arg1__ = null;
                try
                {
#line 286 "C:\\Demo\\Quantum-Arithmetic-QSharp\\QSharpBasicArithmetics\\Operations.qs"
                    var array2 = QArray<Boolean>.Create(n);
#line 287 "C:\\Demo\\Quantum-Arithmetic-QSharp\\QSharpBasicArithmetics\\Operations.qs"
                    var tempInt2 = b;
#line 288 "C:\\Demo\\Quantum-Arithmetic-QSharp\\QSharpBasicArithmetics\\Operations.qs"
                    foreach (var idxBit in new Range(0L, (n - 1L)))
#line hidden
                    {
#line 289 "C:\\Demo\\Quantum-Arithmetic-QSharp\\QSharpBasicArithmetics\\Operations.qs"
                        array2.Modify(((n - 1L) - idxBit), (((tempInt2 % 2L) == 0L) ? false : true));
#line 290 "C:\\Demo\\Quantum-Arithmetic-QSharp\\QSharpBasicArithmetics\\Operations.qs"
                        tempInt2 = (tempInt2 / 2L);
                    }

#line 292 "C:\\Demo\\Quantum-Arithmetic-QSharp\\QSharpBasicArithmetics\\Operations.qs"
                    foreach (var idx in new Range(0L, (n - 1L)))
#line hidden
                    {
#line 293 "C:\\Demo\\Quantum-Arithmetic-QSharp\\QSharpBasicArithmetics\\Operations.qs"
                        if (array2[idx])
                        {
#line 294 "C:\\Demo\\Quantum-Arithmetic-QSharp\\QSharpBasicArithmetics\\Operations.qs"
                            MicrosoftQuantumIntrinsicX.Apply(x[idx]);
                        }
                    }

#line 299 "C:\\Demo\\Quantum-Arithmetic-QSharp\\QSharpBasicArithmetics\\Operations.qs"
                    QuantumExponent.Apply((a, x));
#line 302 "C:\\Demo\\Quantum-Arithmetic-QSharp\\QSharpBasicArithmetics\\Operations.qs"
                    foreach (var idx in new Range(0L, (n - 1L)))
#line hidden
                    {
#line 303 "C:\\Demo\\Quantum-Arithmetic-QSharp\\QSharpBasicArithmetics\\Operations.qs"
                        resultArray.Modify(idx, MicrosoftQuantumMeasurementMResetZ.Apply(x[idx]));
                    }
                }
#line hidden
                catch (Exception __arg2__)
                {
                    __arg1__ = __arg2__;
                    throw __arg1__;
                }
#line hidden
                finally
                {
                    if (__arg1__ != null)
                    {
                        throw __arg1__;
                    }

#line hidden
                    Release.Apply(x);
                }
            }

#line 308 "C:\\Demo\\Quantum-Arithmetic-QSharp\\QSharpBasicArithmetics\\Operations.qs"
            var resultBool = (IQArray<Boolean>)MicrosoftQuantumConvertResultArrayAsBoolArray.Apply(resultArray?.Copy());
#line 309 "C:\\Demo\\Quantum-Arithmetic-QSharp\\QSharpBasicArithmetics\\Operations.qs"
            var resultInt = 0L;
#line 310 "C:\\Demo\\Quantum-Arithmetic-QSharp\\QSharpBasicArithmetics\\Operations.qs"
            foreach (var idx in new Range(0L, (n - 1L)))
#line hidden
            {
#line 311 "C:\\Demo\\Quantum-Arithmetic-QSharp\\QSharpBasicArithmetics\\Operations.qs"
                if (resultBool[idx])
                {
#line 312 "C:\\Demo\\Quantum-Arithmetic-QSharp\\QSharpBasicArithmetics\\Operations.qs"
                    resultInt = (resultInt + 2L.Pow(((n - 1L) - idx)));
                }
            }

#line 315 "C:\\Demo\\Quantum-Arithmetic-QSharp\\QSharpBasicArithmetics\\Operations.qs"
            return resultInt;
        }

        ;
        public override void Init()
        {
            this.MicrosoftQuantumConvertResultArrayAsBoolArray = this.Factory.Get<ICallable<IQArray<Result>, IQArray<Boolean>>>(typeof(Microsoft.Quantum.Convert.ResultArrayAsBoolArray));
            this.Allocate = this.Factory.Get<Allocate>(typeof(Microsoft.Quantum.Intrinsic.Allocate));
            this.Release = this.Factory.Get<Release>(typeof(Microsoft.Quantum.Intrinsic.Release));
            this.MicrosoftQuantumIntrinsicX = this.Factory.Get<IUnitary<Qubit>>(typeof(Microsoft.Quantum.Intrinsic.X));
            this.MicrosoftQuantumMeasurementMResetZ = this.Factory.Get<ICallable<Qubit, Result>>(typeof(Microsoft.Quantum.Measurement.MResetZ));
            this.QuantumExponent = this.Factory.Get<ICallable<(Int64,IQArray<Qubit>), QVoid>>(typeof(QuantumExponent));
        }

        public override IApplyData __dataIn((Int64,Int64,Int64) data) => new In(data);
        public override IApplyData __dataOut(Int64 data) => new QTuple<Int64>(data);
        public static System.Threading.Tasks.Task<Int64> Run(IOperationFactory __m__, Int64 a, Int64 b, Int64 n)
        {
            return __m__.Run<TestQuantumExponent, (Int64,Int64,Int64), Int64>((a, b, n));
        }
    }

    public class QuantumAddByModulus : Unitary<(Int64,IQArray<Qubit>,IQArray<Qubit>)>, ICallable
    {
        public QuantumAddByModulus(IOperationFactory m) : base(m)
        {
        }

        public class In : QTuple<(Int64,IQArray<Qubit>,IQArray<Qubit>)>, IApplyData
        {
            public In((Int64,IQArray<Qubit>,IQArray<Qubit>) data) : base(data)
            {
            }

            System.Collections.Generic.IEnumerable<Qubit> IApplyData.Qubits => Qubit.Concat(((IApplyData)Data.Item2)?.Qubits, ((IApplyData)Data.Item3)?.Qubits);
        }

        String ICallable.Name => "QuantumAddByModulus";
        String ICallable.FullName => "Quantum.QSharpBasicArithmetics.QuantumAddByModulus";
        protected Allocate Allocate
        {
            get;
            set;
        }

        protected Release Release
        {
            get;
            set;
        }

        protected IUnitary<Qubit> MicrosoftQuantumIntrinsicX
        {
            get;
            set;
        }

        protected IUnitary<(IQArray<Qubit>,IQArray<Qubit>)> QuantumAdd
        {
            get;
            set;
        }

        protected IUnitary<(IQArray<Qubit>,Int64)> QuantumAddByNumber
        {
            get;
            set;
        }

        public override Func<(Int64,IQArray<Qubit>,IQArray<Qubit>), QVoid> Body => (__in__) =>
        {
            var (N,x,y) = __in__;
#line hidden
            {
#line 323 "C:\\Demo\\Quantum-Arithmetic-QSharp\\QSharpBasicArithmetics\\Operations.qs"
                var (ancilla,cx,cy) = (Allocate.Apply(), Allocate.Apply(), Allocate.Apply());
#line hidden
                Exception __arg1__ = null;
                try
                {
#line 325 "C:\\Demo\\Quantum-Arithmetic-QSharp\\QSharpBasicArithmetics\\Operations.qs"
                    var x_large = (IQArray<Qubit>)QArray<Qubit>.Add(new QArray<Qubit>(cx), x);
#line 326 "C:\\Demo\\Quantum-Arithmetic-QSharp\\QSharpBasicArithmetics\\Operations.qs"
                    var y_large = (IQArray<Qubit>)QArray<Qubit>.Add(new QArray<Qubit>(cy), y);
#line 328 "C:\\Demo\\Quantum-Arithmetic-QSharp\\QSharpBasicArithmetics\\Operations.qs"
                    QuantumAdd.Apply((x_large, y_large));
#line 330 "C:\\Demo\\Quantum-Arithmetic-QSharp\\QSharpBasicArithmetics\\Operations.qs"
                    QuantumAddByNumber.Adjoint.Apply((y_large, N));
#line 332 "C:\\Demo\\Quantum-Arithmetic-QSharp\\QSharpBasicArithmetics\\Operations.qs"
                    MicrosoftQuantumIntrinsicX.Controlled.Apply((new QArray<Qubit>(y_large[0L]), ancilla));
#line 334 "C:\\Demo\\Quantum-Arithmetic-QSharp\\QSharpBasicArithmetics\\Operations.qs"
                    QuantumAddByNumber.Controlled.Apply((new QArray<Qubit>(ancilla), (y_large, N)));
#line 336 "C:\\Demo\\Quantum-Arithmetic-QSharp\\QSharpBasicArithmetics\\Operations.qs"
                    QuantumAdd.Adjoint.Apply((x_large, y_large));
#line 337 "C:\\Demo\\Quantum-Arithmetic-QSharp\\QSharpBasicArithmetics\\Operations.qs"
                    MicrosoftQuantumIntrinsicX.Apply(ancilla);
#line 338 "C:\\Demo\\Quantum-Arithmetic-QSharp\\QSharpBasicArithmetics\\Operations.qs"
                    MicrosoftQuantumIntrinsicX.Controlled.Apply((new QArray<Qubit>(y_large[0L]), ancilla));
#line 339 "C:\\Demo\\Quantum-Arithmetic-QSharp\\QSharpBasicArithmetics\\Operations.qs"
                    QuantumAdd.Apply((x_large, y_large));
                }
#line hidden
                catch (Exception __arg2__)
                {
                    __arg1__ = __arg2__;
                    throw __arg1__;
                }
#line hidden
                finally
                {
                    if (__arg1__ != null)
                    {
                        throw __arg1__;
                    }

#line hidden
                    Release.Apply(ancilla);
#line hidden
                    Release.Apply(cx);
#line hidden
                    Release.Apply(cy);
                }
            }

#line hidden
            return QVoid.Instance;
        }

        ;
        public override Func<(Int64,IQArray<Qubit>,IQArray<Qubit>), QVoid> AdjointBody => (__in__) =>
        {
            var (N,x,y) = __in__;
#line hidden
            {
#line hidden
                var (ancilla,cx,cy) = (Allocate.Apply(), Allocate.Apply(), Allocate.Apply());
#line hidden
                Exception __arg1__ = null;
                try
                {
#line hidden
                    var x_large = (IQArray<Qubit>)QArray<Qubit>.Add(new QArray<Qubit>(cx), x);
#line hidden
                    var y_large = (IQArray<Qubit>)QArray<Qubit>.Add(new QArray<Qubit>(cy), y);
#line hidden
                    QuantumAdd.Adjoint.Apply((x_large, y_large));
#line hidden
                    MicrosoftQuantumIntrinsicX.Controlled.Adjoint.Apply((new QArray<Qubit>(y_large[0L]), ancilla));
#line hidden
                    MicrosoftQuantumIntrinsicX.Adjoint.Apply(ancilla);
#line hidden
                    QuantumAdd.Adjoint.Adjoint.Apply((x_large, y_large));
#line hidden
                    QuantumAddByNumber.Controlled.Adjoint.Apply((new QArray<Qubit>(ancilla), (y_large, N)));
#line hidden
                    MicrosoftQuantumIntrinsicX.Controlled.Adjoint.Apply((new QArray<Qubit>(y_large[0L]), ancilla));
#line hidden
                    QuantumAddByNumber.Adjoint.Adjoint.Apply((y_large, N));
#line hidden
                    QuantumAdd.Adjoint.Apply((x_large, y_large));
                }
#line hidden
                catch (Exception __arg2__)
                {
                    __arg1__ = __arg2__;
                    throw __arg1__;
                }
#line hidden
                finally
                {
                    if (__arg1__ != null)
                    {
                        throw __arg1__;
                    }

#line hidden
                    Release.Apply(ancilla);
#line hidden
                    Release.Apply(cx);
#line hidden
                    Release.Apply(cy);
                }
            }

#line hidden
            return QVoid.Instance;
        }

        ;
        public override Func<(IQArray<Qubit>,(Int64,IQArray<Qubit>,IQArray<Qubit>)), QVoid> ControlledBody => (__in__) =>
        {
            var (__controlQubits__,(N,x,y)) = __in__;
#line hidden
            {
#line hidden
                var (ancilla,cx,cy) = (Allocate.Apply(), Allocate.Apply(), Allocate.Apply());
#line hidden
                Exception __arg1__ = null;
                try
                {
#line hidden
                    var x_large = (IQArray<Qubit>)QArray<Qubit>.Add(new QArray<Qubit>(cx), x);
#line hidden
                    var y_large = (IQArray<Qubit>)QArray<Qubit>.Add(new QArray<Qubit>(cy), y);
#line hidden
                    QuantumAdd.Controlled.Apply((__controlQubits__, (x_large, y_large)));
#line hidden
                    QuantumAddByNumber.Adjoint.Controlled.Apply((__controlQubits__, (y_large, N)));
#line hidden
                    MicrosoftQuantumIntrinsicX.Controlled.Controlled.Apply((__controlQubits__, (new QArray<Qubit>(y_large[0L]), ancilla)));
#line hidden
                    QuantumAddByNumber.Controlled.Controlled.Apply((__controlQubits__, (new QArray<Qubit>(ancilla), (y_large, N))));
#line hidden
                    QuantumAdd.Adjoint.Controlled.Apply((__controlQubits__, (x_large, y_large)));
#line hidden
                    MicrosoftQuantumIntrinsicX.Controlled.Apply((__controlQubits__, ancilla));
#line hidden
                    MicrosoftQuantumIntrinsicX.Controlled.Controlled.Apply((__controlQubits__, (new QArray<Qubit>(y_large[0L]), ancilla)));
#line hidden
                    QuantumAdd.Controlled.Apply((__controlQubits__, (x_large, y_large)));
                }
#line hidden
                catch (Exception __arg2__)
                {
                    __arg1__ = __arg2__;
                    throw __arg1__;
                }
#line hidden
                finally
                {
                    if (__arg1__ != null)
                    {
                        throw __arg1__;
                    }

#line hidden
                    Release.Apply(ancilla);
#line hidden
                    Release.Apply(cx);
#line hidden
                    Release.Apply(cy);
                }
            }

#line hidden
            return QVoid.Instance;
        }

        ;
        public override Func<(IQArray<Qubit>,(Int64,IQArray<Qubit>,IQArray<Qubit>)), QVoid> ControlledAdjointBody => (__in__) =>
        {
            var (__controlQubits__,(N,x,y)) = __in__;
#line hidden
            {
#line hidden
                var (ancilla,cx,cy) = (Allocate.Apply(), Allocate.Apply(), Allocate.Apply());
#line hidden
                Exception __arg1__ = null;
                try
                {
#line hidden
                    var x_large = (IQArray<Qubit>)QArray<Qubit>.Add(new QArray<Qubit>(cx), x);
#line hidden
                    var y_large = (IQArray<Qubit>)QArray<Qubit>.Add(new QArray<Qubit>(cy), y);
#line hidden
                    QuantumAdd.Adjoint.Controlled.Apply((__controlQubits__, (x_large, y_large)));
#line hidden
                    MicrosoftQuantumIntrinsicX.Controlled.Adjoint.Controlled.Apply((__controlQubits__, (new QArray<Qubit>(y_large[0L]), ancilla)));
#line hidden
                    MicrosoftQuantumIntrinsicX.Adjoint.Controlled.Apply((__controlQubits__, ancilla));
#line hidden
                    QuantumAdd.Adjoint.Adjoint.Controlled.Apply((__controlQubits__, (x_large, y_large)));
#line hidden
                    QuantumAddByNumber.Controlled.Adjoint.Controlled.Apply((__controlQubits__, (new QArray<Qubit>(ancilla), (y_large, N))));
#line hidden
                    MicrosoftQuantumIntrinsicX.Controlled.Adjoint.Controlled.Apply((__controlQubits__, (new QArray<Qubit>(y_large[0L]), ancilla)));
#line hidden
                    QuantumAddByNumber.Adjoint.Adjoint.Controlled.Apply((__controlQubits__, (y_large, N)));
#line hidden
                    QuantumAdd.Adjoint.Controlled.Apply((__controlQubits__, (x_large, y_large)));
                }
#line hidden
                catch (Exception __arg2__)
                {
                    __arg1__ = __arg2__;
                    throw __arg1__;
                }
#line hidden
                finally
                {
                    if (__arg1__ != null)
                    {
                        throw __arg1__;
                    }

#line hidden
                    Release.Apply(ancilla);
#line hidden
                    Release.Apply(cx);
#line hidden
                    Release.Apply(cy);
                }
            }

#line hidden
            return QVoid.Instance;
        }

        ;
        public override void Init()
        {
            this.Allocate = this.Factory.Get<Allocate>(typeof(Microsoft.Quantum.Intrinsic.Allocate));
            this.Release = this.Factory.Get<Release>(typeof(Microsoft.Quantum.Intrinsic.Release));
            this.MicrosoftQuantumIntrinsicX = this.Factory.Get<IUnitary<Qubit>>(typeof(Microsoft.Quantum.Intrinsic.X));
            this.QuantumAdd = this.Factory.Get<IUnitary<(IQArray<Qubit>,IQArray<Qubit>)>>(typeof(QuantumAdd));
            this.QuantumAddByNumber = this.Factory.Get<IUnitary<(IQArray<Qubit>,Int64)>>(typeof(QuantumAddByNumber));
        }

        public override IApplyData __dataIn((Int64,IQArray<Qubit>,IQArray<Qubit>) data) => new In(data);
        public override IApplyData __dataOut(QVoid data) => data;
        public static System.Threading.Tasks.Task<QVoid> Run(IOperationFactory __m__, Int64 N, IQArray<Qubit> x, IQArray<Qubit> y)
        {
            return __m__.Run<QuantumAddByModulus, (Int64,IQArray<Qubit>,IQArray<Qubit>), QVoid>((N, x, y));
        }
    }

    public class QuantumMultiplyByModulus : Unitary<(Int64,Int64,IQArray<Qubit>)>, ICallable
    {
        public QuantumMultiplyByModulus(IOperationFactory m) : base(m)
        {
        }

        public class In : QTuple<(Int64,Int64,IQArray<Qubit>)>, IApplyData
        {
            public In((Int64,Int64,IQArray<Qubit>) data) : base(data)
            {
            }

            System.Collections.Generic.IEnumerable<Qubit> IApplyData.Qubits => ((IApplyData)Data.Item3)?.Qubits;
        }

        String ICallable.Name => "QuantumMultiplyByModulus";
        String ICallable.FullName => "Quantum.QSharpBasicArithmetics.QuantumMultiplyByModulus";
        protected ICallable MicrosoftQuantumArraysZip
        {
            get;
            set;
        }

        protected IUnitary MicrosoftQuantumCanonApplyToEachCA
        {
            get;
            set;
        }

        protected ICallable Length
        {
            get;
            set;
        }

        protected ICallable<Range, Range> RangeReverse
        {
            get;
            set;
        }

        protected Allocate Allocate
        {
            get;
            set;
        }

        protected Release Release
        {
            get;
            set;
        }

        protected IUnitary<(Qubit,Qubit)> MicrosoftQuantumIntrinsicSWAP
        {
            get;
            set;
        }

        protected ICallable<(Int64,Int64), Int64> MicrosoftQuantumMathInverseModI
        {
            get;
            set;
        }

        protected IUnitary<(Int64,IQArray<Qubit>,IQArray<Qubit>)> QuantumAddByModulus
        {
            get;
            set;
        }

        public override Func<(Int64,Int64,IQArray<Qubit>), QVoid> Body => (__in__) =>
        {
            var (N,a,y) = __in__;
#line 352 "C:\\Demo\\Quantum-Arithmetic-QSharp\\QSharpBasicArithmetics\\Operations.qs"
            var n = y.Length;
#line 353 "C:\\Demo\\Quantum-Arithmetic-QSharp\\QSharpBasicArithmetics\\Operations.qs"
            var a_mod = (a % N);
#line hidden
            {
#line 355 "C:\\Demo\\Quantum-Arithmetic-QSharp\\QSharpBasicArithmetics\\Operations.qs"
                var s = Allocate.Apply(n);
#line hidden
                Exception __arg1__ = null;
                try
                {
#line 359 "C:\\Demo\\Quantum-Arithmetic-QSharp\\QSharpBasicArithmetics\\Operations.qs"
                    foreach (var r in new Range(0L, (a_mod - 1L)))
#line hidden
                    {
#line 360 "C:\\Demo\\Quantum-Arithmetic-QSharp\\QSharpBasicArithmetics\\Operations.qs"
                        QuantumAddByModulus.Apply((N, y, s));
                    }

#line 365 "C:\\Demo\\Quantum-Arithmetic-QSharp\\QSharpBasicArithmetics\\Operations.qs"
                    MicrosoftQuantumCanonApplyToEachCA.Apply((MicrosoftQuantumIntrinsicSWAP, MicrosoftQuantumArraysZip.Apply<IQArray<(Qubit,Qubit)>>((y, s))));
#line 370 "C:\\Demo\\Quantum-Arithmetic-QSharp\\QSharpBasicArithmetics\\Operations.qs"
                    var a_inv = MicrosoftQuantumMathInverseModI.Apply((a_mod, N));
#line 371 "C:\\Demo\\Quantum-Arithmetic-QSharp\\QSharpBasicArithmetics\\Operations.qs"
                    foreach (var r in new Range(0L, (a_inv - 1L)))
#line hidden
                    {
#line 372 "C:\\Demo\\Quantum-Arithmetic-QSharp\\QSharpBasicArithmetics\\Operations.qs"
                        QuantumAddByModulus.Adjoint.Apply((N, y, s));
                    }
                }
#line hidden
                catch (Exception __arg2__)
                {
                    __arg1__ = __arg2__;
                    throw __arg1__;
                }
#line hidden
                finally
                {
                    if (__arg1__ != null)
                    {
                        throw __arg1__;
                    }

#line hidden
                    Release.Apply(s);
                }
            }

#line hidden
            return QVoid.Instance;
        }

        ;
        public override Func<(Int64,Int64,IQArray<Qubit>), QVoid> AdjointBody => (__in__) =>
        {
            var (N,a,y) = __in__;
#line hidden
            var n = y.Length;
#line hidden
            var a_mod = (a % N);
#line hidden
            {
#line hidden
                var s = Allocate.Apply(n);
#line hidden
                Exception __arg1__ = null;
                try
                {
#line hidden
                    var a_inv = MicrosoftQuantumMathInverseModI.Apply((a_mod, N));
#line hidden
                    foreach (var r in RangeReverse.Apply(new Range(0L, (a_inv - 1L))))
#line hidden
                    {
#line hidden
                        QuantumAddByModulus.Adjoint.Adjoint.Apply((N, y, s));
                    }

#line hidden
                    MicrosoftQuantumCanonApplyToEachCA.Adjoint.Apply((MicrosoftQuantumIntrinsicSWAP, MicrosoftQuantumArraysZip.Apply<IQArray<(Qubit,Qubit)>>((y, s))));
#line hidden
                    foreach (var r in RangeReverse.Apply(new Range(0L, (a_mod - 1L))))
#line hidden
                    {
#line hidden
                        QuantumAddByModulus.Adjoint.Apply((N, y, s));
                    }
                }
#line hidden
                catch (Exception __arg2__)
                {
                    __arg1__ = __arg2__;
                    throw __arg1__;
                }
#line hidden
                finally
                {
                    if (__arg1__ != null)
                    {
                        throw __arg1__;
                    }

#line hidden
                    Release.Apply(s);
                }
            }

#line hidden
            return QVoid.Instance;
        }

        ;
        public override Func<(IQArray<Qubit>,(Int64,Int64,IQArray<Qubit>)), QVoid> ControlledBody => (__in__) =>
        {
            var (__controlQubits__,(N,a,y)) = __in__;
#line hidden
            var n = y.Length;
#line hidden
            var a_mod = (a % N);
#line hidden
            {
#line hidden
                var s = Allocate.Apply(n);
#line hidden
                Exception __arg1__ = null;
                try
                {
#line hidden
                    foreach (var r in new Range(0L, (a_mod - 1L)))
#line hidden
                    {
#line hidden
                        QuantumAddByModulus.Controlled.Apply((__controlQubits__, (N, y, s)));
                    }

#line hidden
                    MicrosoftQuantumCanonApplyToEachCA.Controlled.Apply((__controlQubits__, (MicrosoftQuantumIntrinsicSWAP, MicrosoftQuantumArraysZip.Apply<IQArray<(Qubit,Qubit)>>((y, s)))));
#line hidden
                    var a_inv = MicrosoftQuantumMathInverseModI.Apply((a_mod, N));
#line hidden
                    foreach (var r in new Range(0L, (a_inv - 1L)))
#line hidden
                    {
#line hidden
                        QuantumAddByModulus.Adjoint.Controlled.Apply((__controlQubits__, (N, y, s)));
                    }
                }
#line hidden
                catch (Exception __arg2__)
                {
                    __arg1__ = __arg2__;
                    throw __arg1__;
                }
#line hidden
                finally
                {
                    if (__arg1__ != null)
                    {
                        throw __arg1__;
                    }

#line hidden
                    Release.Apply(s);
                }
            }

#line hidden
            return QVoid.Instance;
        }

        ;
        public override Func<(IQArray<Qubit>,(Int64,Int64,IQArray<Qubit>)), QVoid> ControlledAdjointBody => (__in__) =>
        {
            var (__controlQubits__,(N,a,y)) = __in__;
#line hidden
            var n = y.Length;
#line hidden
            var a_mod = (a % N);
#line hidden
            {
#line hidden
                var s = Allocate.Apply(n);
#line hidden
                Exception __arg1__ = null;
                try
                {
#line hidden
                    var a_inv = MicrosoftQuantumMathInverseModI.Apply((a_mod, N));
#line hidden
                    foreach (var r in RangeReverse.Apply(new Range(0L, (a_inv - 1L))))
#line hidden
                    {
#line hidden
                        QuantumAddByModulus.Adjoint.Adjoint.Controlled.Apply((__controlQubits__, (N, y, s)));
                    }

#line hidden
                    MicrosoftQuantumCanonApplyToEachCA.Adjoint.Controlled.Apply((__controlQubits__, (MicrosoftQuantumIntrinsicSWAP, MicrosoftQuantumArraysZip.Apply<IQArray<(Qubit,Qubit)>>((y, s)))));
#line hidden
                    foreach (var r in RangeReverse.Apply(new Range(0L, (a_mod - 1L))))
#line hidden
                    {
#line hidden
                        QuantumAddByModulus.Adjoint.Controlled.Apply((__controlQubits__, (N, y, s)));
                    }
                }
#line hidden
                catch (Exception __arg2__)
                {
                    __arg1__ = __arg2__;
                    throw __arg1__;
                }
#line hidden
                finally
                {
                    if (__arg1__ != null)
                    {
                        throw __arg1__;
                    }

#line hidden
                    Release.Apply(s);
                }
            }

#line hidden
            return QVoid.Instance;
        }

        ;
        public override void Init()
        {
            this.MicrosoftQuantumArraysZip = this.Factory.Get<ICallable>(typeof(Microsoft.Quantum.Arrays.Zip<,>));
            this.MicrosoftQuantumCanonApplyToEachCA = this.Factory.Get<IUnitary>(typeof(Microsoft.Quantum.Canon.ApplyToEachCA<>));
            this.Length = this.Factory.Get<ICallable>(typeof(Microsoft.Quantum.Core.Length<>));
            this.RangeReverse = this.Factory.Get<ICallable<Range, Range>>(typeof(Microsoft.Quantum.Core.RangeReverse));
            this.Allocate = this.Factory.Get<Allocate>(typeof(Microsoft.Quantum.Intrinsic.Allocate));
            this.Release = this.Factory.Get<Release>(typeof(Microsoft.Quantum.Intrinsic.Release));
            this.MicrosoftQuantumIntrinsicSWAP = this.Factory.Get<IUnitary<(Qubit,Qubit)>>(typeof(Microsoft.Quantum.Intrinsic.SWAP));
            this.MicrosoftQuantumMathInverseModI = this.Factory.Get<ICallable<(Int64,Int64), Int64>>(typeof(Microsoft.Quantum.Math.InverseModI));
            this.QuantumAddByModulus = this.Factory.Get<IUnitary<(Int64,IQArray<Qubit>,IQArray<Qubit>)>>(typeof(QuantumAddByModulus));
        }

        public override IApplyData __dataIn((Int64,Int64,IQArray<Qubit>) data) => new In(data);
        public override IApplyData __dataOut(QVoid data) => data;
        public static System.Threading.Tasks.Task<QVoid> Run(IOperationFactory __m__, Int64 N, Int64 a, IQArray<Qubit> y)
        {
            return __m__.Run<QuantumMultiplyByModulus, (Int64,Int64,IQArray<Qubit>), QVoid>((N, a, y));
        }
    }

    public class QuantumExponentByModulus : Operation<(Int64,Int64,IQArray<Qubit>), QVoid>, ICallable
    {
        public QuantumExponentByModulus(IOperationFactory m) : base(m)
        {
        }

        public class In : QTuple<(Int64,Int64,IQArray<Qubit>)>, IApplyData
        {
            public In((Int64,Int64,IQArray<Qubit>) data) : base(data)
            {
            }

            System.Collections.Generic.IEnumerable<Qubit> IApplyData.Qubits => ((IApplyData)Data.Item3)?.Qubits;
        }

        String ICallable.Name => "QuantumExponentByModulus";
        String ICallable.FullName => "Quantum.QSharpBasicArithmetics.QuantumExponentByModulus";
        protected ICallable MicrosoftQuantumArraysZip
        {
            get;
            set;
        }

        protected IUnitary MicrosoftQuantumCanonApplyToEachCA
        {
            get;
            set;
        }

        protected ICallable Length
        {
            get;
            set;
        }

        protected Allocate Allocate
        {
            get;
            set;
        }

        protected Release Release
        {
            get;
            set;
        }

        protected ICallable<Qubit, QVoid> MicrosoftQuantumIntrinsicReset
        {
            get;
            set;
        }

        protected IUnitary<(Qubit,Qubit)> MicrosoftQuantumIntrinsicSWAP
        {
            get;
            set;
        }

        protected IUnitary<Qubit> MicrosoftQuantumIntrinsicX
        {
            get;
            set;
        }

        protected IUnitary<(Int64,Int64,IQArray<Qubit>)> QuantumMultiplyByModulus
        {
            get;
            set;
        }

        public override Func<(Int64,Int64,IQArray<Qubit>), QVoid> Body => (__in__) =>
        {
            var (N,a,x) = __in__;
#line 386 "C:\\Demo\\Quantum-Arithmetic-QSharp\\QSharpBasicArithmetics\\Operations.qs"
            var n = x.Length;
#line hidden
            {
#line 387 "C:\\Demo\\Quantum-Arithmetic-QSharp\\QSharpBasicArithmetics\\Operations.qs"
                var s = Allocate.Apply(n);
#line hidden
                Exception __arg1__ = null;
                try
                {
#line 389 "C:\\Demo\\Quantum-Arithmetic-QSharp\\QSharpBasicArithmetics\\Operations.qs"
                    MicrosoftQuantumIntrinsicX.Apply(s[(n - 1L)]);
#line 392 "C:\\Demo\\Quantum-Arithmetic-QSharp\\QSharpBasicArithmetics\\Operations.qs"
                    foreach (var idx in new Range(0L, (n - 1L)))
#line hidden
                    {
#line 393 "C:\\Demo\\Quantum-Arithmetic-QSharp\\QSharpBasicArithmetics\\Operations.qs"
                        QuantumMultiplyByModulus.Controlled.Apply((new QArray<Qubit>(x[idx]), (N, a.Pow(2L.Pow(((n - 1L) - idx))), s)));
                    }

#line 397 "C:\\Demo\\Quantum-Arithmetic-QSharp\\QSharpBasicArithmetics\\Operations.qs"
                    MicrosoftQuantumCanonApplyToEachCA.Apply((MicrosoftQuantumIntrinsicSWAP, MicrosoftQuantumArraysZip.Apply<IQArray<(Qubit,Qubit)>>((x, s))));
#line 400 "C:\\Demo\\Quantum-Arithmetic-QSharp\\QSharpBasicArithmetics\\Operations.qs"
                    foreach (var idx in new Range(0L, (n - 1L)))
#line hidden
                    {
#line 401 "C:\\Demo\\Quantum-Arithmetic-QSharp\\QSharpBasicArithmetics\\Operations.qs"
                        MicrosoftQuantumIntrinsicReset.Apply(s[idx]);
                    }
                }
#line hidden
                catch (Exception __arg2__)
                {
                    __arg1__ = __arg2__;
                    throw __arg1__;
                }
#line hidden
                finally
                {
                    if (__arg1__ != null)
                    {
                        throw __arg1__;
                    }

#line hidden
                    Release.Apply(s);
                }
            }

#line hidden
            return QVoid.Instance;
        }

        ;
        public override void Init()
        {
            this.MicrosoftQuantumArraysZip = this.Factory.Get<ICallable>(typeof(Microsoft.Quantum.Arrays.Zip<,>));
            this.MicrosoftQuantumCanonApplyToEachCA = this.Factory.Get<IUnitary>(typeof(Microsoft.Quantum.Canon.ApplyToEachCA<>));
            this.Length = this.Factory.Get<ICallable>(typeof(Microsoft.Quantum.Core.Length<>));
            this.Allocate = this.Factory.Get<Allocate>(typeof(Microsoft.Quantum.Intrinsic.Allocate));
            this.Release = this.Factory.Get<Release>(typeof(Microsoft.Quantum.Intrinsic.Release));
            this.MicrosoftQuantumIntrinsicReset = this.Factory.Get<ICallable<Qubit, QVoid>>(typeof(Microsoft.Quantum.Intrinsic.Reset));
            this.MicrosoftQuantumIntrinsicSWAP = this.Factory.Get<IUnitary<(Qubit,Qubit)>>(typeof(Microsoft.Quantum.Intrinsic.SWAP));
            this.MicrosoftQuantumIntrinsicX = this.Factory.Get<IUnitary<Qubit>>(typeof(Microsoft.Quantum.Intrinsic.X));
            this.QuantumMultiplyByModulus = this.Factory.Get<IUnitary<(Int64,Int64,IQArray<Qubit>)>>(typeof(QuantumMultiplyByModulus));
        }

        public override IApplyData __dataIn((Int64,Int64,IQArray<Qubit>) data) => new In(data);
        public override IApplyData __dataOut(QVoid data) => data;
        public static System.Threading.Tasks.Task<QVoid> Run(IOperationFactory __m__, Int64 N, Int64 a, IQArray<Qubit> x)
        {
            return __m__.Run<QuantumExponentByModulus, (Int64,Int64,IQArray<Qubit>), QVoid>((N, a, x));
        }
    }

    public class TestQuantumAddByModulus : Operation<(Int64,Int64,Int64,Int64), Int64>, ICallable
    {
        public TestQuantumAddByModulus(IOperationFactory m) : base(m)
        {
        }

        public class In : QTuple<(Int64,Int64,Int64,Int64)>, IApplyData
        {
            public In((Int64,Int64,Int64,Int64) data) : base(data)
            {
            }

            System.Collections.Generic.IEnumerable<Qubit> IApplyData.Qubits => null;
        }

        String ICallable.Name => "TestQuantumAddByModulus";
        String ICallable.FullName => "Quantum.QSharpBasicArithmetics.TestQuantumAddByModulus";
        protected ICallable<IQArray<Result>, IQArray<Boolean>> MicrosoftQuantumConvertResultArrayAsBoolArray
        {
            get;
            set;
        }

        protected Allocate Allocate
        {
            get;
            set;
        }

        protected Release Release
        {
            get;
            set;
        }

        protected ICallable<Qubit, QVoid> MicrosoftQuantumIntrinsicReset
        {
            get;
            set;
        }

        protected IUnitary<Qubit> MicrosoftQuantumIntrinsicX
        {
            get;
            set;
        }

        protected ICallable<Qubit, Result> MicrosoftQuantumMeasurementMResetZ
        {
            get;
            set;
        }

        protected IUnitary<(Int64,IQArray<Qubit>,IQArray<Qubit>)> QuantumAddByModulus
        {
            get;
            set;
        }

        public override Func<(Int64,Int64,Int64,Int64), Int64> Body => (__in__) =>
        {
            var (a,b,n,N) = __in__;
#line 407 "C:\\Demo\\Quantum-Arithmetic-QSharp\\QSharpBasicArithmetics\\Operations.qs"
            var resultArray = QArray<Result>.Create(n);
#line hidden
            {
#line 409 "C:\\Demo\\Quantum-Arithmetic-QSharp\\QSharpBasicArithmetics\\Operations.qs"
                var (x,y) = (Allocate.Apply(n), Allocate.Apply(n));
#line hidden
                Exception __arg1__ = null;
                try
                {
#line 411 "C:\\Demo\\Quantum-Arithmetic-QSharp\\QSharpBasicArithmetics\\Operations.qs"
                    var array1 = QArray<Boolean>.Create(n);
#line 412 "C:\\Demo\\Quantum-Arithmetic-QSharp\\QSharpBasicArithmetics\\Operations.qs"
                    var tempInt1 = a;
#line 413 "C:\\Demo\\Quantum-Arithmetic-QSharp\\QSharpBasicArithmetics\\Operations.qs"
                    foreach (var idxBit in new Range(0L, (n - 1L)))
#line hidden
                    {
#line 414 "C:\\Demo\\Quantum-Arithmetic-QSharp\\QSharpBasicArithmetics\\Operations.qs"
                        array1.Modify(((n - 1L) - idxBit), (((tempInt1 % 2L) == 0L) ? false : true));
#line 415 "C:\\Demo\\Quantum-Arithmetic-QSharp\\QSharpBasicArithmetics\\Operations.qs"
                        tempInt1 = (tempInt1 / 2L);
                    }

#line 417 "C:\\Demo\\Quantum-Arithmetic-QSharp\\QSharpBasicArithmetics\\Operations.qs"
                    foreach (var idx in new Range(0L, (n - 1L)))
#line hidden
                    {
#line 418 "C:\\Demo\\Quantum-Arithmetic-QSharp\\QSharpBasicArithmetics\\Operations.qs"
                        if (array1[idx])
                        {
#line 419 "C:\\Demo\\Quantum-Arithmetic-QSharp\\QSharpBasicArithmetics\\Operations.qs"
                            MicrosoftQuantumIntrinsicX.Apply(x[idx]);
                        }
                    }

#line 424 "C:\\Demo\\Quantum-Arithmetic-QSharp\\QSharpBasicArithmetics\\Operations.qs"
                    var array2 = QArray<Boolean>.Create(n);
#line 425 "C:\\Demo\\Quantum-Arithmetic-QSharp\\QSharpBasicArithmetics\\Operations.qs"
                    var tempInt2 = b;
#line 426 "C:\\Demo\\Quantum-Arithmetic-QSharp\\QSharpBasicArithmetics\\Operations.qs"
                    foreach (var idxBit in new Range(0L, (n - 1L)))
#line hidden
                    {
#line 427 "C:\\Demo\\Quantum-Arithmetic-QSharp\\QSharpBasicArithmetics\\Operations.qs"
                        array2.Modify(((n - 1L) - idxBit), (((tempInt2 % 2L) == 0L) ? false : true));
#line 428 "C:\\Demo\\Quantum-Arithmetic-QSharp\\QSharpBasicArithmetics\\Operations.qs"
                        tempInt2 = (tempInt2 / 2L);
                    }

#line 430 "C:\\Demo\\Quantum-Arithmetic-QSharp\\QSharpBasicArithmetics\\Operations.qs"
                    foreach (var idx in new Range(0L, (n - 1L)))
#line hidden
                    {
#line 431 "C:\\Demo\\Quantum-Arithmetic-QSharp\\QSharpBasicArithmetics\\Operations.qs"
                        if (array2[idx])
                        {
#line 432 "C:\\Demo\\Quantum-Arithmetic-QSharp\\QSharpBasicArithmetics\\Operations.qs"
                            MicrosoftQuantumIntrinsicX.Apply(y[idx]);
                        }
                    }

#line 437 "C:\\Demo\\Quantum-Arithmetic-QSharp\\QSharpBasicArithmetics\\Operations.qs"
                    QuantumAddByModulus.Apply((N, x, y));
#line 443 "C:\\Demo\\Quantum-Arithmetic-QSharp\\QSharpBasicArithmetics\\Operations.qs"
                    foreach (var idx in new Range(0L, (n - 1L)))
#line hidden
                    {
#line 444 "C:\\Demo\\Quantum-Arithmetic-QSharp\\QSharpBasicArithmetics\\Operations.qs"
                        resultArray.Modify(idx, MicrosoftQuantumMeasurementMResetZ.Apply(y[idx]));
                    }

#line 446 "C:\\Demo\\Quantum-Arithmetic-QSharp\\QSharpBasicArithmetics\\Operations.qs"
                    foreach (var idx in new Range(0L, (n - 1L)))
#line hidden
                    {
#line 447 "C:\\Demo\\Quantum-Arithmetic-QSharp\\QSharpBasicArithmetics\\Operations.qs"
                        MicrosoftQuantumIntrinsicReset.Apply(x[idx]);
                    }
                }
#line hidden
                catch (Exception __arg2__)
                {
                    __arg1__ = __arg2__;
                    throw __arg1__;
                }
#line hidden
                finally
                {
                    if (__arg1__ != null)
                    {
                        throw __arg1__;
                    }

#line hidden
                    Release.Apply(x);
#line hidden
                    Release.Apply(y);
                }
            }

#line 452 "C:\\Demo\\Quantum-Arithmetic-QSharp\\QSharpBasicArithmetics\\Operations.qs"
            var resultBool = (IQArray<Boolean>)MicrosoftQuantumConvertResultArrayAsBoolArray.Apply(resultArray?.Copy());
#line 453 "C:\\Demo\\Quantum-Arithmetic-QSharp\\QSharpBasicArithmetics\\Operations.qs"
            var resultInt = 0L;
#line 454 "C:\\Demo\\Quantum-Arithmetic-QSharp\\QSharpBasicArithmetics\\Operations.qs"
            foreach (var idx in new Range(0L, (n - 1L)))
#line hidden
            {
#line 455 "C:\\Demo\\Quantum-Arithmetic-QSharp\\QSharpBasicArithmetics\\Operations.qs"
                if (resultBool[idx])
                {
#line 456 "C:\\Demo\\Quantum-Arithmetic-QSharp\\QSharpBasicArithmetics\\Operations.qs"
                    resultInt = (resultInt + 2L.Pow(((n - 1L) - idx)));
                }
            }

#line 459 "C:\\Demo\\Quantum-Arithmetic-QSharp\\QSharpBasicArithmetics\\Operations.qs"
            return resultInt;
        }

        ;
        public override void Init()
        {
            this.MicrosoftQuantumConvertResultArrayAsBoolArray = this.Factory.Get<ICallable<IQArray<Result>, IQArray<Boolean>>>(typeof(Microsoft.Quantum.Convert.ResultArrayAsBoolArray));
            this.Allocate = this.Factory.Get<Allocate>(typeof(Microsoft.Quantum.Intrinsic.Allocate));
            this.Release = this.Factory.Get<Release>(typeof(Microsoft.Quantum.Intrinsic.Release));
            this.MicrosoftQuantumIntrinsicReset = this.Factory.Get<ICallable<Qubit, QVoid>>(typeof(Microsoft.Quantum.Intrinsic.Reset));
            this.MicrosoftQuantumIntrinsicX = this.Factory.Get<IUnitary<Qubit>>(typeof(Microsoft.Quantum.Intrinsic.X));
            this.MicrosoftQuantumMeasurementMResetZ = this.Factory.Get<ICallable<Qubit, Result>>(typeof(Microsoft.Quantum.Measurement.MResetZ));
            this.QuantumAddByModulus = this.Factory.Get<IUnitary<(Int64,IQArray<Qubit>,IQArray<Qubit>)>>(typeof(QuantumAddByModulus));
        }

        public override IApplyData __dataIn((Int64,Int64,Int64,Int64) data) => new In(data);
        public override IApplyData __dataOut(Int64 data) => new QTuple<Int64>(data);
        public static System.Threading.Tasks.Task<Int64> Run(IOperationFactory __m__, Int64 a, Int64 b, Int64 n, Int64 N)
        {
            return __m__.Run<TestQuantumAddByModulus, (Int64,Int64,Int64,Int64), Int64>((a, b, n, N));
        }
    }

    public class QFTImpl : Unitary<IQArray<Qubit>>, ICallable
    {
        public QFTImpl(IOperationFactory m) : base(m)
        {
        }

        String ICallable.Name => "QFTImpl";
        String ICallable.FullName => "Quantum.QSharpBasicArithmetics.QFTImpl";
        protected IUnitary<IQArray<Qubit>> MicrosoftQuantumCanonSwapReverseRegister
        {
            get;
            set;
        }

        protected ICallable Length
        {
            get;
            set;
        }

        protected ICallable<Range, Range> RangeReverse
        {
            get;
            set;
        }

        protected IUnitary<Qubit> MicrosoftQuantumIntrinsicH
        {
            get;
            set;
        }

        protected IUnitary<(Int64,Int64,Qubit)> MicrosoftQuantumIntrinsicR1Frac
        {
            get;
            set;
        }

        public override Func<IQArray<Qubit>, QVoid> Body => (__in__) =>
        {
            var qs = __in__;
#line 471 "C:\\Demo\\Quantum-Arithmetic-QSharp\\QSharpBasicArithmetics\\Operations.qs"
            var nQubits = qs.Length;
#line 473 "C:\\Demo\\Quantum-Arithmetic-QSharp\\QSharpBasicArithmetics\\Operations.qs"
            foreach (var i in new Range(0L, (nQubits - 1L)))
#line hidden
            {
#line 475 "C:\\Demo\\Quantum-Arithmetic-QSharp\\QSharpBasicArithmetics\\Operations.qs"
                MicrosoftQuantumIntrinsicH.Apply(qs[i]);
#line 476 "C:\\Demo\\Quantum-Arithmetic-QSharp\\QSharpBasicArithmetics\\Operations.qs"
                foreach (var j in new Range((i + 1L), (nQubits - 1L)))
#line hidden
                {
#line 478 "C:\\Demo\\Quantum-Arithmetic-QSharp\\QSharpBasicArithmetics\\Operations.qs"
                    MicrosoftQuantumIntrinsicR1Frac.Controlled.Apply((new QArray<Qubit>(qs[j]), (1L, (j - i), qs[i])));
                }
            }

#line 482 "C:\\Demo\\Quantum-Arithmetic-QSharp\\QSharpBasicArithmetics\\Operations.qs"
            MicrosoftQuantumCanonSwapReverseRegister.Apply(qs);
#line hidden
            return QVoid.Instance;
        }

        ;
        public override Func<IQArray<Qubit>, QVoid> AdjointBody => (__in__) =>
        {
            var qs = __in__;
#line hidden
            var nQubits = qs.Length;
#line hidden
            MicrosoftQuantumCanonSwapReverseRegister.Adjoint.Apply(qs);
#line hidden
            foreach (var i in RangeReverse.Apply(new Range(0L, (nQubits - 1L))))
#line hidden
            {
#line hidden
                foreach (var j in RangeReverse.Apply(new Range((i + 1L), (nQubits - 1L))))
#line hidden
                {
#line hidden
                    MicrosoftQuantumIntrinsicR1Frac.Controlled.Adjoint.Apply((new QArray<Qubit>(qs[j]), (1L, (j - i), qs[i])));
                }

#line hidden
                MicrosoftQuantumIntrinsicH.Adjoint.Apply(qs[i]);
            }

#line hidden
            return QVoid.Instance;
        }

        ;
        public override Func<(IQArray<Qubit>,IQArray<Qubit>), QVoid> ControlledBody => (__in__) =>
        {
            var (__controlQubits__,qs) = __in__;
#line hidden
            var nQubits = qs.Length;
#line hidden
            foreach (var i in new Range(0L, (nQubits - 1L)))
#line hidden
            {
#line hidden
                MicrosoftQuantumIntrinsicH.Controlled.Apply((__controlQubits__, qs[i]));
#line hidden
                foreach (var j in new Range((i + 1L), (nQubits - 1L)))
#line hidden
                {
#line hidden
                    MicrosoftQuantumIntrinsicR1Frac.Controlled.Controlled.Apply((__controlQubits__, (new QArray<Qubit>(qs[j]), (1L, (j - i), qs[i]))));
                }
            }

#line hidden
            MicrosoftQuantumCanonSwapReverseRegister.Controlled.Apply((__controlQubits__, qs));
#line hidden
            return QVoid.Instance;
        }

        ;
        public override Func<(IQArray<Qubit>,IQArray<Qubit>), QVoid> ControlledAdjointBody => (__in__) =>
        {
            var (__controlQubits__,qs) = __in__;
#line hidden
            var nQubits = qs.Length;
#line hidden
            MicrosoftQuantumCanonSwapReverseRegister.Adjoint.Controlled.Apply((__controlQubits__, qs));
#line hidden
            foreach (var i in RangeReverse.Apply(new Range(0L, (nQubits - 1L))))
#line hidden
            {
#line hidden
                foreach (var j in RangeReverse.Apply(new Range((i + 1L), (nQubits - 1L))))
#line hidden
                {
#line hidden
                    MicrosoftQuantumIntrinsicR1Frac.Controlled.Adjoint.Controlled.Apply((__controlQubits__, (new QArray<Qubit>(qs[j]), (1L, (j - i), qs[i]))));
                }

#line hidden
                MicrosoftQuantumIntrinsicH.Adjoint.Controlled.Apply((__controlQubits__, qs[i]));
            }

#line hidden
            return QVoid.Instance;
        }

        ;
        public override void Init()
        {
            this.MicrosoftQuantumCanonSwapReverseRegister = this.Factory.Get<IUnitary<IQArray<Qubit>>>(typeof(Microsoft.Quantum.Canon.SwapReverseRegister));
            this.Length = this.Factory.Get<ICallable>(typeof(Microsoft.Quantum.Core.Length<>));
            this.RangeReverse = this.Factory.Get<ICallable<Range, Range>>(typeof(Microsoft.Quantum.Core.RangeReverse));
            this.MicrosoftQuantumIntrinsicH = this.Factory.Get<IUnitary<Qubit>>(typeof(Microsoft.Quantum.Intrinsic.H));
            this.MicrosoftQuantumIntrinsicR1Frac = this.Factory.Get<IUnitary<(Int64,Int64,Qubit)>>(typeof(Microsoft.Quantum.Intrinsic.R1Frac));
        }

        public override IApplyData __dataIn(IQArray<Qubit> data) => data;
        public override IApplyData __dataOut(QVoid data) => data;
        public static System.Threading.Tasks.Task<QVoid> Run(IOperationFactory __m__, IQArray<Qubit> qs)
        {
            return __m__.Run<QFTImpl, IQArray<Qubit>, QVoid>(qs);
        }
    }
}