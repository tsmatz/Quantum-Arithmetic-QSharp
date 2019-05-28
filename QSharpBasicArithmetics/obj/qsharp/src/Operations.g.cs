#pragma warning disable 1591
using System;
using Microsoft.Quantum.Core;
using Microsoft.Quantum.Intrinsic;
using Microsoft.Quantum.Simulation.Core;

[assembly: CallableDeclaration("{\"Kind\":{\"Case\":\"Operation\"},\"QualifiedName\":{\"Namespace\":\"Quantum.QSharpBasicArithmetics\",\"Name\":\"ModularAdd\"},\"SourceFile\":\"C:/Demo/Quantum-Arithmetic-QSharp/QSharpBasicArithmetics/Operations.qs\",\"Position\":{\"Item1\":10,\"Item2\":4},\"SymbolRange\":{\"Item1\":{\"Line\":1,\"Column\":11},\"Item2\":{\"Line\":1,\"Column\":21}},\"ArgumentTuple\":{\"Case\":\"QsTuple\",\"Fields\":[[{\"Case\":\"QsTupleItem\",\"Fields\":[{\"VariableName\":{\"Case\":\"ValidName\",\"Fields\":[\"x\"]},\"Type\":{\"Case\":\"ArrayType\",\"Fields\":[{\"Case\":\"Qubit\"}]},\"IsMutable\":false,\"HasLocalQuantumDependency\":false,\"Position\":{\"Case\":\"Null\"},\"Range\":{\"Item1\":{\"Line\":1,\"Column\":23},\"Item2\":{\"Line\":1,\"Column\":24}}}]},{\"Case\":\"QsTupleItem\",\"Fields\":[{\"VariableName\":{\"Case\":\"ValidName\",\"Fields\":[\"y\"]},\"Type\":{\"Case\":\"ArrayType\",\"Fields\":[{\"Case\":\"Qubit\"}]},\"IsMutable\":false,\"HasLocalQuantumDependency\":false,\"Position\":{\"Case\":\"Null\"},\"Range\":{\"Item1\":{\"Line\":1,\"Column\":36},\"Item2\":{\"Line\":1,\"Column\":37}}}]}]]},\"Signature\":{\"TypeParameters\":[],\"ArgumentType\":{\"Case\":\"TupleType\",\"Fields\":[[{\"Case\":\"ArrayType\",\"Fields\":[{\"Case\":\"Qubit\"}]},{\"Case\":\"ArrayType\",\"Fields\":[{\"Case\":\"Qubit\"}]}]]},\"ReturnType\":{\"Case\":\"UnitType\"},\"Information\":{\"Affiliation\":{\"Case\":\"Union\",\"Fields\":[{\"Case\":\"SimpleSet\",\"Fields\":[{\"Case\":\"Adjointable\"}]},{\"Case\":\"SimpleSet\",\"Fields\":[{\"Case\":\"Controllable\"}]}]},\"InferredInformation\":{\"IsSelfAdjoint\":false,\"IsIntrinsic\":false}}},\"Documentation\":[]}")]
[assembly: SpecializationDeclaration("{\"Kind\":{\"Case\":\"QsBody\"},\"TypeArguments\":{\"Case\":\"Null\"},\"Information\":{\"Affiliation\":{\"Case\":\"Union\",\"Fields\":[{\"Case\":\"SimpleSet\",\"Fields\":[{\"Case\":\"Adjointable\"}]},{\"Case\":\"SimpleSet\",\"Fields\":[{\"Case\":\"Controllable\"}]}]},\"InferredInformation\":{\"IsSelfAdjoint\":false,\"IsIntrinsic\":false}},\"Parent\":{\"Namespace\":\"Quantum.QSharpBasicArithmetics\",\"Name\":\"ModularAdd\"},\"SourceFile\":\"C:/Demo/Quantum-Arithmetic-QSharp/QSharpBasicArithmetics/Operations.qs\",\"Position\":{\"Item1\":10,\"Item2\":4},\"HeaderRange\":{\"Item1\":{\"Line\":1,\"Column\":11},\"Item2\":{\"Line\":1,\"Column\":21}},\"Documentation\":[]}")]
[assembly: SpecializationDeclaration("{\"Kind\":{\"Case\":\"QsAdjoint\"},\"TypeArguments\":{\"Case\":\"Null\"},\"Information\":{\"Affiliation\":{\"Case\":\"Union\",\"Fields\":[{\"Case\":\"SimpleSet\",\"Fields\":[{\"Case\":\"Adjointable\"}]},{\"Case\":\"SimpleSet\",\"Fields\":[{\"Case\":\"Controllable\"}]}]},\"InferredInformation\":{\"IsSelfAdjoint\":false,\"IsIntrinsic\":false}},\"Parent\":{\"Namespace\":\"Quantum.QSharpBasicArithmetics\",\"Name\":\"ModularAdd\"},\"SourceFile\":\"C:/Demo/Quantum-Arithmetic-QSharp/QSharpBasicArithmetics/Operations.qs\",\"Position\":{\"Item1\":10,\"Item2\":4},\"HeaderRange\":{\"Item1\":{\"Line\":1,\"Column\":59},\"Item2\":{\"Line\":1,\"Column\":68}},\"Documentation\":[\"automatically generated QsAdjoint specialization for Quantum.QSharpBasicArithmetics.ModularAdd\"]}")]
[assembly: SpecializationDeclaration("{\"Kind\":{\"Case\":\"QsControlled\"},\"TypeArguments\":{\"Case\":\"Null\"},\"Information\":{\"Affiliation\":{\"Case\":\"Union\",\"Fields\":[{\"Case\":\"SimpleSet\",\"Fields\":[{\"Case\":\"Adjointable\"}]},{\"Case\":\"SimpleSet\",\"Fields\":[{\"Case\":\"Controllable\"}]}]},\"InferredInformation\":{\"IsSelfAdjoint\":false,\"IsIntrinsic\":false}},\"Parent\":{\"Namespace\":\"Quantum.QSharpBasicArithmetics\",\"Name\":\"ModularAdd\"},\"SourceFile\":\"C:/Demo/Quantum-Arithmetic-QSharp/QSharpBasicArithmetics/Operations.qs\",\"Position\":{\"Item1\":10,\"Item2\":4},\"HeaderRange\":{\"Item1\":{\"Line\":1,\"Column\":59},\"Item2\":{\"Line\":1,\"Column\":68}},\"Documentation\":[\"automatically generated QsControlled specialization for Quantum.QSharpBasicArithmetics.ModularAdd\"]}")]
[assembly: SpecializationDeclaration("{\"Kind\":{\"Case\":\"QsControlledAdjoint\"},\"TypeArguments\":{\"Case\":\"Null\"},\"Information\":{\"Affiliation\":{\"Case\":\"Union\",\"Fields\":[{\"Case\":\"SimpleSet\",\"Fields\":[{\"Case\":\"Adjointable\"}]},{\"Case\":\"SimpleSet\",\"Fields\":[{\"Case\":\"Controllable\"}]}]},\"InferredInformation\":{\"IsSelfAdjoint\":false,\"IsIntrinsic\":false}},\"Parent\":{\"Namespace\":\"Quantum.QSharpBasicArithmetics\",\"Name\":\"ModularAdd\"},\"SourceFile\":\"C:/Demo/Quantum-Arithmetic-QSharp/QSharpBasicArithmetics/Operations.qs\",\"Position\":{\"Item1\":10,\"Item2\":4},\"HeaderRange\":{\"Item1\":{\"Line\":1,\"Column\":59},\"Item2\":{\"Line\":1,\"Column\":68}},\"Documentation\":[\"automatically generated QsControlledAdjoint specialization for Quantum.QSharpBasicArithmetics.ModularAdd\"]}")]
[assembly: CallableDeclaration("{\"Kind\":{\"Case\":\"Operation\"},\"QualifiedName\":{\"Namespace\":\"Quantum.QSharpBasicArithmetics\",\"Name\":\"TestModularAdd\"},\"SourceFile\":\"C:/Demo/Quantum-Arithmetic-QSharp/QSharpBasicArithmetics/Operations.qs\",\"Position\":{\"Item1\":21,\"Item2\":4},\"SymbolRange\":{\"Item1\":{\"Line\":1,\"Column\":11},\"Item2\":{\"Line\":1,\"Column\":25}},\"ArgumentTuple\":{\"Case\":\"QsTuple\",\"Fields\":[[{\"Case\":\"QsTupleItem\",\"Fields\":[{\"VariableName\":{\"Case\":\"ValidName\",\"Fields\":[\"a\"]},\"Type\":{\"Case\":\"Int\"},\"IsMutable\":false,\"HasLocalQuantumDependency\":false,\"Position\":{\"Case\":\"Null\"},\"Range\":{\"Item1\":{\"Line\":1,\"Column\":27},\"Item2\":{\"Line\":1,\"Column\":28}}}]},{\"Case\":\"QsTupleItem\",\"Fields\":[{\"VariableName\":{\"Case\":\"ValidName\",\"Fields\":[\"b\"]},\"Type\":{\"Case\":\"Int\"},\"IsMutable\":false,\"HasLocalQuantumDependency\":false,\"Position\":{\"Case\":\"Null\"},\"Range\":{\"Item1\":{\"Line\":1,\"Column\":36},\"Item2\":{\"Line\":1,\"Column\":37}}}]},{\"Case\":\"QsTupleItem\",\"Fields\":[{\"VariableName\":{\"Case\":\"ValidName\",\"Fields\":[\"n\"]},\"Type\":{\"Case\":\"Int\"},\"IsMutable\":false,\"HasLocalQuantumDependency\":false,\"Position\":{\"Case\":\"Null\"},\"Range\":{\"Item1\":{\"Line\":1,\"Column\":45},\"Item2\":{\"Line\":1,\"Column\":46}}}]}]]},\"Signature\":{\"TypeParameters\":[],\"ArgumentType\":{\"Case\":\"TupleType\",\"Fields\":[[{\"Case\":\"Int\"},{\"Case\":\"Int\"},{\"Case\":\"Int\"}]]},\"ReturnType\":{\"Case\":\"Int\"},\"Information\":{\"Affiliation\":{\"Case\":\"EmptySet\"},\"InferredInformation\":{\"IsSelfAdjoint\":false,\"IsIntrinsic\":false}}},\"Documentation\":[]}")]
[assembly: SpecializationDeclaration("{\"Kind\":{\"Case\":\"QsBody\"},\"TypeArguments\":{\"Case\":\"Null\"},\"Information\":{\"Affiliation\":{\"Case\":\"EmptySet\"},\"InferredInformation\":{\"IsSelfAdjoint\":false,\"IsIntrinsic\":false}},\"Parent\":{\"Namespace\":\"Quantum.QSharpBasicArithmetics\",\"Name\":\"TestModularAdd\"},\"SourceFile\":\"C:/Demo/Quantum-Arithmetic-QSharp/QSharpBasicArithmetics/Operations.qs\",\"Position\":{\"Item1\":21,\"Item2\":4},\"HeaderRange\":{\"Item1\":{\"Line\":1,\"Column\":11},\"Item2\":{\"Line\":1,\"Column\":25}},\"Documentation\":[]}")]
[assembly: CallableDeclaration("{\"Kind\":{\"Case\":\"Operation\"},\"QualifiedName\":{\"Namespace\":\"Quantum.QSharpBasicArithmetics\",\"Name\":\"TestModularSub\"},\"SourceFile\":\"C:/Demo/Quantum-Arithmetic-QSharp/QSharpBasicArithmetics/Operations.qs\",\"Position\":{\"Item1\":74,\"Item2\":4},\"SymbolRange\":{\"Item1\":{\"Line\":1,\"Column\":11},\"Item2\":{\"Line\":1,\"Column\":25}},\"ArgumentTuple\":{\"Case\":\"QsTuple\",\"Fields\":[[{\"Case\":\"QsTupleItem\",\"Fields\":[{\"VariableName\":{\"Case\":\"ValidName\",\"Fields\":[\"a\"]},\"Type\":{\"Case\":\"Int\"},\"IsMutable\":false,\"HasLocalQuantumDependency\":false,\"Position\":{\"Case\":\"Null\"},\"Range\":{\"Item1\":{\"Line\":1,\"Column\":27},\"Item2\":{\"Line\":1,\"Column\":28}}}]},{\"Case\":\"QsTupleItem\",\"Fields\":[{\"VariableName\":{\"Case\":\"ValidName\",\"Fields\":[\"b\"]},\"Type\":{\"Case\":\"Int\"},\"IsMutable\":false,\"HasLocalQuantumDependency\":false,\"Position\":{\"Case\":\"Null\"},\"Range\":{\"Item1\":{\"Line\":1,\"Column\":36},\"Item2\":{\"Line\":1,\"Column\":37}}}]},{\"Case\":\"QsTupleItem\",\"Fields\":[{\"VariableName\":{\"Case\":\"ValidName\",\"Fields\":[\"n\"]},\"Type\":{\"Case\":\"Int\"},\"IsMutable\":false,\"HasLocalQuantumDependency\":false,\"Position\":{\"Case\":\"Null\"},\"Range\":{\"Item1\":{\"Line\":1,\"Column\":45},\"Item2\":{\"Line\":1,\"Column\":46}}}]}]]},\"Signature\":{\"TypeParameters\":[],\"ArgumentType\":{\"Case\":\"TupleType\",\"Fields\":[[{\"Case\":\"Int\"},{\"Case\":\"Int\"},{\"Case\":\"Int\"}]]},\"ReturnType\":{\"Case\":\"Int\"},\"Information\":{\"Affiliation\":{\"Case\":\"EmptySet\"},\"InferredInformation\":{\"IsSelfAdjoint\":false,\"IsIntrinsic\":false}}},\"Documentation\":[]}")]
[assembly: SpecializationDeclaration("{\"Kind\":{\"Case\":\"QsBody\"},\"TypeArguments\":{\"Case\":\"Null\"},\"Information\":{\"Affiliation\":{\"Case\":\"EmptySet\"},\"InferredInformation\":{\"IsSelfAdjoint\":false,\"IsIntrinsic\":false}},\"Parent\":{\"Namespace\":\"Quantum.QSharpBasicArithmetics\",\"Name\":\"TestModularSub\"},\"SourceFile\":\"C:/Demo/Quantum-Arithmetic-QSharp/QSharpBasicArithmetics/Operations.qs\",\"Position\":{\"Item1\":74,\"Item2\":4},\"HeaderRange\":{\"Item1\":{\"Line\":1,\"Column\":11},\"Item2\":{\"Line\":1,\"Column\":25}},\"Documentation\":[]}")]
[assembly: CallableDeclaration("{\"Kind\":{\"Case\":\"Operation\"},\"QualifiedName\":{\"Namespace\":\"Quantum.QSharpBasicArithmetics\",\"Name\":\"ModularAddByNumber\"},\"SourceFile\":\"C:/Demo/Quantum-Arithmetic-QSharp/QSharpBasicArithmetics/Operations.qs\",\"Position\":{\"Item1\":130,\"Item2\":4},\"SymbolRange\":{\"Item1\":{\"Line\":1,\"Column\":11},\"Item2\":{\"Line\":1,\"Column\":29}},\"ArgumentTuple\":{\"Case\":\"QsTuple\",\"Fields\":[[{\"Case\":\"QsTupleItem\",\"Fields\":[{\"VariableName\":{\"Case\":\"ValidName\",\"Fields\":[\"x\"]},\"Type\":{\"Case\":\"ArrayType\",\"Fields\":[{\"Case\":\"Qubit\"}]},\"IsMutable\":false,\"HasLocalQuantumDependency\":false,\"Position\":{\"Case\":\"Null\"},\"Range\":{\"Item1\":{\"Line\":1,\"Column\":31},\"Item2\":{\"Line\":1,\"Column\":32}}}]},{\"Case\":\"QsTupleItem\",\"Fields\":[{\"VariableName\":{\"Case\":\"ValidName\",\"Fields\":[\"b\"]},\"Type\":{\"Case\":\"Int\"},\"IsMutable\":false,\"HasLocalQuantumDependency\":false,\"Position\":{\"Case\":\"Null\"},\"Range\":{\"Item1\":{\"Line\":1,\"Column\":44},\"Item2\":{\"Line\":1,\"Column\":45}}}]}]]},\"Signature\":{\"TypeParameters\":[],\"ArgumentType\":{\"Case\":\"TupleType\",\"Fields\":[[{\"Case\":\"ArrayType\",\"Fields\":[{\"Case\":\"Qubit\"}]},{\"Case\":\"Int\"}]]},\"ReturnType\":{\"Case\":\"UnitType\"},\"Information\":{\"Affiliation\":{\"Case\":\"SimpleSet\",\"Fields\":[{\"Case\":\"Controllable\"}]},\"InferredInformation\":{\"IsSelfAdjoint\":false,\"IsIntrinsic\":false}}},\"Documentation\":[]}")]
[assembly: SpecializationDeclaration("{\"Kind\":{\"Case\":\"QsBody\"},\"TypeArguments\":{\"Case\":\"Null\"},\"Information\":{\"Affiliation\":{\"Case\":\"SimpleSet\",\"Fields\":[{\"Case\":\"Controllable\"}]},\"InferredInformation\":{\"IsSelfAdjoint\":false,\"IsIntrinsic\":false}},\"Parent\":{\"Namespace\":\"Quantum.QSharpBasicArithmetics\",\"Name\":\"ModularAddByNumber\"},\"SourceFile\":\"C:/Demo/Quantum-Arithmetic-QSharp/QSharpBasicArithmetics/Operations.qs\",\"Position\":{\"Item1\":130,\"Item2\":4},\"HeaderRange\":{\"Item1\":{\"Line\":1,\"Column\":11},\"Item2\":{\"Line\":1,\"Column\":29}},\"Documentation\":[]}")]
[assembly: SpecializationDeclaration("{\"Kind\":{\"Case\":\"QsControlled\"},\"TypeArguments\":{\"Case\":\"Null\"},\"Information\":{\"Affiliation\":{\"Case\":\"SimpleSet\",\"Fields\":[{\"Case\":\"Controllable\"}]},\"InferredInformation\":{\"IsSelfAdjoint\":false,\"IsIntrinsic\":false}},\"Parent\":{\"Namespace\":\"Quantum.QSharpBasicArithmetics\",\"Name\":\"ModularAddByNumber\"},\"SourceFile\":\"C:/Demo/Quantum-Arithmetic-QSharp/QSharpBasicArithmetics/Operations.qs\",\"Position\":{\"Item1\":130,\"Item2\":4},\"HeaderRange\":{\"Item1\":{\"Line\":1,\"Column\":63},\"Item2\":{\"Line\":1,\"Column\":66}},\"Documentation\":[\"automatically generated QsControlled specialization for Quantum.QSharpBasicArithmetics.ModularAddByNumber\"]}")]
[assembly: CallableDeclaration("{\"Kind\":{\"Case\":\"Operation\"},\"QualifiedName\":{\"Namespace\":\"Quantum.QSharpBasicArithmetics\",\"Name\":\"TestModularAddByNumber\"},\"SourceFile\":\"C:/Demo/Quantum-Arithmetic-QSharp/QSharpBasicArithmetics/Operations.qs\",\"Position\":{\"Item1\":153,\"Item2\":4},\"SymbolRange\":{\"Item1\":{\"Line\":1,\"Column\":11},\"Item2\":{\"Line\":1,\"Column\":33}},\"ArgumentTuple\":{\"Case\":\"QsTuple\",\"Fields\":[[{\"Case\":\"QsTupleItem\",\"Fields\":[{\"VariableName\":{\"Case\":\"ValidName\",\"Fields\":[\"a\"]},\"Type\":{\"Case\":\"Int\"},\"IsMutable\":false,\"HasLocalQuantumDependency\":false,\"Position\":{\"Case\":\"Null\"},\"Range\":{\"Item1\":{\"Line\":1,\"Column\":35},\"Item2\":{\"Line\":1,\"Column\":36}}}]},{\"Case\":\"QsTupleItem\",\"Fields\":[{\"VariableName\":{\"Case\":\"ValidName\",\"Fields\":[\"b\"]},\"Type\":{\"Case\":\"Int\"},\"IsMutable\":false,\"HasLocalQuantumDependency\":false,\"Position\":{\"Case\":\"Null\"},\"Range\":{\"Item1\":{\"Line\":1,\"Column\":44},\"Item2\":{\"Line\":1,\"Column\":45}}}]},{\"Case\":\"QsTupleItem\",\"Fields\":[{\"VariableName\":{\"Case\":\"ValidName\",\"Fields\":[\"n\"]},\"Type\":{\"Case\":\"Int\"},\"IsMutable\":false,\"HasLocalQuantumDependency\":false,\"Position\":{\"Case\":\"Null\"},\"Range\":{\"Item1\":{\"Line\":1,\"Column\":53},\"Item2\":{\"Line\":1,\"Column\":54}}}]}]]},\"Signature\":{\"TypeParameters\":[],\"ArgumentType\":{\"Case\":\"TupleType\",\"Fields\":[[{\"Case\":\"Int\"},{\"Case\":\"Int\"},{\"Case\":\"Int\"}]]},\"ReturnType\":{\"Case\":\"Int\"},\"Information\":{\"Affiliation\":{\"Case\":\"EmptySet\"},\"InferredInformation\":{\"IsSelfAdjoint\":false,\"IsIntrinsic\":false}}},\"Documentation\":[]}")]
[assembly: SpecializationDeclaration("{\"Kind\":{\"Case\":\"QsBody\"},\"TypeArguments\":{\"Case\":\"Null\"},\"Information\":{\"Affiliation\":{\"Case\":\"EmptySet\"},\"InferredInformation\":{\"IsSelfAdjoint\":false,\"IsIntrinsic\":false}},\"Parent\":{\"Namespace\":\"Quantum.QSharpBasicArithmetics\",\"Name\":\"TestModularAddByNumber\"},\"SourceFile\":\"C:/Demo/Quantum-Arithmetic-QSharp/QSharpBasicArithmetics/Operations.qs\",\"Position\":{\"Item1\":153,\"Item2\":4},\"HeaderRange\":{\"Item1\":{\"Line\":1,\"Column\":11},\"Item2\":{\"Line\":1,\"Column\":33}},\"Documentation\":[]}")]
[assembly: CallableDeclaration("{\"Kind\":{\"Case\":\"Operation\"},\"QualifiedName\":{\"Namespace\":\"Quantum.QSharpBasicArithmetics\",\"Name\":\"ModularMultiply\"},\"SourceFile\":\"C:/Demo/Quantum-Arithmetic-QSharp/QSharpBasicArithmetics/Operations.qs\",\"Position\":{\"Item1\":197,\"Item2\":4},\"SymbolRange\":{\"Item1\":{\"Line\":1,\"Column\":11},\"Item2\":{\"Line\":1,\"Column\":26}},\"ArgumentTuple\":{\"Case\":\"QsTuple\",\"Fields\":[[{\"Case\":\"QsTupleItem\",\"Fields\":[{\"VariableName\":{\"Case\":\"ValidName\",\"Fields\":[\"a\"]},\"Type\":{\"Case\":\"Int\"},\"IsMutable\":false,\"HasLocalQuantumDependency\":false,\"Position\":{\"Case\":\"Null\"},\"Range\":{\"Item1\":{\"Line\":1,\"Column\":28},\"Item2\":{\"Line\":1,\"Column\":29}}}]},{\"Case\":\"QsTupleItem\",\"Fields\":[{\"VariableName\":{\"Case\":\"ValidName\",\"Fields\":[\"y\"]},\"Type\":{\"Case\":\"ArrayType\",\"Fields\":[{\"Case\":\"Qubit\"}]},\"IsMutable\":false,\"HasLocalQuantumDependency\":false,\"Position\":{\"Case\":\"Null\"},\"Range\":{\"Item1\":{\"Line\":1,\"Column\":37},\"Item2\":{\"Line\":1,\"Column\":38}}}]}]]},\"Signature\":{\"TypeParameters\":[],\"ArgumentType\":{\"Case\":\"TupleType\",\"Fields\":[[{\"Case\":\"Int\"},{\"Case\":\"ArrayType\",\"Fields\":[{\"Case\":\"Qubit\"}]}]]},\"ReturnType\":{\"Case\":\"UnitType\"},\"Information\":{\"Affiliation\":{\"Case\":\"Union\",\"Fields\":[{\"Case\":\"SimpleSet\",\"Fields\":[{\"Case\":\"Adjointable\"}]},{\"Case\":\"SimpleSet\",\"Fields\":[{\"Case\":\"Controllable\"}]}]},\"InferredInformation\":{\"IsSelfAdjoint\":false,\"IsIntrinsic\":false}}},\"Documentation\":[]}")]
[assembly: SpecializationDeclaration("{\"Kind\":{\"Case\":\"QsBody\"},\"TypeArguments\":{\"Case\":\"Null\"},\"Information\":{\"Affiliation\":{\"Case\":\"Union\",\"Fields\":[{\"Case\":\"SimpleSet\",\"Fields\":[{\"Case\":\"Adjointable\"}]},{\"Case\":\"SimpleSet\",\"Fields\":[{\"Case\":\"Controllable\"}]}]},\"InferredInformation\":{\"IsSelfAdjoint\":false,\"IsIntrinsic\":false}},\"Parent\":{\"Namespace\":\"Quantum.QSharpBasicArithmetics\",\"Name\":\"ModularMultiply\"},\"SourceFile\":\"C:/Demo/Quantum-Arithmetic-QSharp/QSharpBasicArithmetics/Operations.qs\",\"Position\":{\"Item1\":197,\"Item2\":4},\"HeaderRange\":{\"Item1\":{\"Line\":1,\"Column\":11},\"Item2\":{\"Line\":1,\"Column\":26}},\"Documentation\":[]}")]
[assembly: SpecializationDeclaration("{\"Kind\":{\"Case\":\"QsAdjoint\"},\"TypeArguments\":{\"Case\":\"Null\"},\"Information\":{\"Affiliation\":{\"Case\":\"Union\",\"Fields\":[{\"Case\":\"SimpleSet\",\"Fields\":[{\"Case\":\"Adjointable\"}]},{\"Case\":\"SimpleSet\",\"Fields\":[{\"Case\":\"Controllable\"}]}]},\"InferredInformation\":{\"IsSelfAdjoint\":false,\"IsIntrinsic\":false}},\"Parent\":{\"Namespace\":\"Quantum.QSharpBasicArithmetics\",\"Name\":\"ModularMultiply\"},\"SourceFile\":\"C:/Demo/Quantum-Arithmetic-QSharp/QSharpBasicArithmetics/Operations.qs\",\"Position\":{\"Item1\":197,\"Item2\":4},\"HeaderRange\":{\"Item1\":{\"Line\":1,\"Column\":60},\"Item2\":{\"Line\":1,\"Column\":69}},\"Documentation\":[\"automatically generated QsAdjoint specialization for Quantum.QSharpBasicArithmetics.ModularMultiply\"]}")]
[assembly: SpecializationDeclaration("{\"Kind\":{\"Case\":\"QsControlled\"},\"TypeArguments\":{\"Case\":\"Null\"},\"Information\":{\"Affiliation\":{\"Case\":\"Union\",\"Fields\":[{\"Case\":\"SimpleSet\",\"Fields\":[{\"Case\":\"Adjointable\"}]},{\"Case\":\"SimpleSet\",\"Fields\":[{\"Case\":\"Controllable\"}]}]},\"InferredInformation\":{\"IsSelfAdjoint\":false,\"IsIntrinsic\":false}},\"Parent\":{\"Namespace\":\"Quantum.QSharpBasicArithmetics\",\"Name\":\"ModularMultiply\"},\"SourceFile\":\"C:/Demo/Quantum-Arithmetic-QSharp/QSharpBasicArithmetics/Operations.qs\",\"Position\":{\"Item1\":197,\"Item2\":4},\"HeaderRange\":{\"Item1\":{\"Line\":1,\"Column\":60},\"Item2\":{\"Line\":1,\"Column\":69}},\"Documentation\":[\"automatically generated QsControlled specialization for Quantum.QSharpBasicArithmetics.ModularMultiply\"]}")]
[assembly: SpecializationDeclaration("{\"Kind\":{\"Case\":\"QsControlledAdjoint\"},\"TypeArguments\":{\"Case\":\"Null\"},\"Information\":{\"Affiliation\":{\"Case\":\"Union\",\"Fields\":[{\"Case\":\"SimpleSet\",\"Fields\":[{\"Case\":\"Adjointable\"}]},{\"Case\":\"SimpleSet\",\"Fields\":[{\"Case\":\"Controllable\"}]}]},\"InferredInformation\":{\"IsSelfAdjoint\":false,\"IsIntrinsic\":false}},\"Parent\":{\"Namespace\":\"Quantum.QSharpBasicArithmetics\",\"Name\":\"ModularMultiply\"},\"SourceFile\":\"C:/Demo/Quantum-Arithmetic-QSharp/QSharpBasicArithmetics/Operations.qs\",\"Position\":{\"Item1\":197,\"Item2\":4},\"HeaderRange\":{\"Item1\":{\"Line\":1,\"Column\":60},\"Item2\":{\"Line\":1,\"Column\":69}},\"Documentation\":[\"automatically generated QsControlledAdjoint specialization for Quantum.QSharpBasicArithmetics.ModularMultiply\"]}")]
[assembly: CallableDeclaration("{\"Kind\":{\"Case\":\"Operation\"},\"QualifiedName\":{\"Namespace\":\"Quantum.QSharpBasicArithmetics\",\"Name\":\"TestModularMultiply\"},\"SourceFile\":\"C:/Demo/Quantum-Arithmetic-QSharp/QSharpBasicArithmetics/Operations.qs\",\"Position\":{\"Item1\":223,\"Item2\":4},\"SymbolRange\":{\"Item1\":{\"Line\":1,\"Column\":11},\"Item2\":{\"Line\":1,\"Column\":30}},\"ArgumentTuple\":{\"Case\":\"QsTuple\",\"Fields\":[[{\"Case\":\"QsTupleItem\",\"Fields\":[{\"VariableName\":{\"Case\":\"ValidName\",\"Fields\":[\"a\"]},\"Type\":{\"Case\":\"Int\"},\"IsMutable\":false,\"HasLocalQuantumDependency\":false,\"Position\":{\"Case\":\"Null\"},\"Range\":{\"Item1\":{\"Line\":1,\"Column\":32},\"Item2\":{\"Line\":1,\"Column\":33}}}]},{\"Case\":\"QsTupleItem\",\"Fields\":[{\"VariableName\":{\"Case\":\"ValidName\",\"Fields\":[\"b\"]},\"Type\":{\"Case\":\"Int\"},\"IsMutable\":false,\"HasLocalQuantumDependency\":false,\"Position\":{\"Case\":\"Null\"},\"Range\":{\"Item1\":{\"Line\":1,\"Column\":41},\"Item2\":{\"Line\":1,\"Column\":42}}}]},{\"Case\":\"QsTupleItem\",\"Fields\":[{\"VariableName\":{\"Case\":\"ValidName\",\"Fields\":[\"n\"]},\"Type\":{\"Case\":\"Int\"},\"IsMutable\":false,\"HasLocalQuantumDependency\":false,\"Position\":{\"Case\":\"Null\"},\"Range\":{\"Item1\":{\"Line\":1,\"Column\":50},\"Item2\":{\"Line\":1,\"Column\":51}}}]}]]},\"Signature\":{\"TypeParameters\":[],\"ArgumentType\":{\"Case\":\"TupleType\",\"Fields\":[[{\"Case\":\"Int\"},{\"Case\":\"Int\"},{\"Case\":\"Int\"}]]},\"ReturnType\":{\"Case\":\"Int\"},\"Information\":{\"Affiliation\":{\"Case\":\"EmptySet\"},\"InferredInformation\":{\"IsSelfAdjoint\":false,\"IsIntrinsic\":false}}},\"Documentation\":[]}")]
[assembly: SpecializationDeclaration("{\"Kind\":{\"Case\":\"QsBody\"},\"TypeArguments\":{\"Case\":\"Null\"},\"Information\":{\"Affiliation\":{\"Case\":\"EmptySet\"},\"InferredInformation\":{\"IsSelfAdjoint\":false,\"IsIntrinsic\":false}},\"Parent\":{\"Namespace\":\"Quantum.QSharpBasicArithmetics\",\"Name\":\"TestModularMultiply\"},\"SourceFile\":\"C:/Demo/Quantum-Arithmetic-QSharp/QSharpBasicArithmetics/Operations.qs\",\"Position\":{\"Item1\":223,\"Item2\":4},\"HeaderRange\":{\"Item1\":{\"Line\":1,\"Column\":11},\"Item2\":{\"Line\":1,\"Column\":30}},\"Documentation\":[]}")]
[assembly: CallableDeclaration("{\"Kind\":{\"Case\":\"Operation\"},\"QualifiedName\":{\"Namespace\":\"Quantum.QSharpBasicArithmetics\",\"Name\":\"ModularExponent\"},\"SourceFile\":\"C:/Demo/Quantum-Arithmetic-QSharp/QSharpBasicArithmetics/Operations.qs\",\"Position\":{\"Item1\":267,\"Item2\":4},\"SymbolRange\":{\"Item1\":{\"Line\":1,\"Column\":11},\"Item2\":{\"Line\":1,\"Column\":26}},\"ArgumentTuple\":{\"Case\":\"QsTuple\",\"Fields\":[[{\"Case\":\"QsTupleItem\",\"Fields\":[{\"VariableName\":{\"Case\":\"ValidName\",\"Fields\":[\"a\"]},\"Type\":{\"Case\":\"Int\"},\"IsMutable\":false,\"HasLocalQuantumDependency\":false,\"Position\":{\"Case\":\"Null\"},\"Range\":{\"Item1\":{\"Line\":1,\"Column\":28},\"Item2\":{\"Line\":1,\"Column\":29}}}]},{\"Case\":\"QsTupleItem\",\"Fields\":[{\"VariableName\":{\"Case\":\"ValidName\",\"Fields\":[\"x\"]},\"Type\":{\"Case\":\"ArrayType\",\"Fields\":[{\"Case\":\"Qubit\"}]},\"IsMutable\":false,\"HasLocalQuantumDependency\":false,\"Position\":{\"Case\":\"Null\"},\"Range\":{\"Item1\":{\"Line\":1,\"Column\":37},\"Item2\":{\"Line\":1,\"Column\":38}}}]}]]},\"Signature\":{\"TypeParameters\":[],\"ArgumentType\":{\"Case\":\"TupleType\",\"Fields\":[[{\"Case\":\"Int\"},{\"Case\":\"ArrayType\",\"Fields\":[{\"Case\":\"Qubit\"}]}]]},\"ReturnType\":{\"Case\":\"UnitType\"},\"Information\":{\"Affiliation\":{\"Case\":\"EmptySet\"},\"InferredInformation\":{\"IsSelfAdjoint\":false,\"IsIntrinsic\":false}}},\"Documentation\":[]}")]
[assembly: SpecializationDeclaration("{\"Kind\":{\"Case\":\"QsBody\"},\"TypeArguments\":{\"Case\":\"Null\"},\"Information\":{\"Affiliation\":{\"Case\":\"EmptySet\"},\"InferredInformation\":{\"IsSelfAdjoint\":false,\"IsIntrinsic\":false}},\"Parent\":{\"Namespace\":\"Quantum.QSharpBasicArithmetics\",\"Name\":\"ModularExponent\"},\"SourceFile\":\"C:/Demo/Quantum-Arithmetic-QSharp/QSharpBasicArithmetics/Operations.qs\",\"Position\":{\"Item1\":267,\"Item2\":4},\"HeaderRange\":{\"Item1\":{\"Line\":1,\"Column\":11},\"Item2\":{\"Line\":1,\"Column\":26}},\"Documentation\":[]}")]
[assembly: CallableDeclaration("{\"Kind\":{\"Case\":\"Operation\"},\"QualifiedName\":{\"Namespace\":\"Quantum.QSharpBasicArithmetics\",\"Name\":\"TestModularExponent\"},\"SourceFile\":\"C:/Demo/Quantum-Arithmetic-QSharp/QSharpBasicArithmetics/Operations.qs\",\"Position\":{\"Item1\":288,\"Item2\":4},\"SymbolRange\":{\"Item1\":{\"Line\":1,\"Column\":11},\"Item2\":{\"Line\":1,\"Column\":30}},\"ArgumentTuple\":{\"Case\":\"QsTuple\",\"Fields\":[[{\"Case\":\"QsTupleItem\",\"Fields\":[{\"VariableName\":{\"Case\":\"ValidName\",\"Fields\":[\"a\"]},\"Type\":{\"Case\":\"Int\"},\"IsMutable\":false,\"HasLocalQuantumDependency\":false,\"Position\":{\"Case\":\"Null\"},\"Range\":{\"Item1\":{\"Line\":1,\"Column\":32},\"Item2\":{\"Line\":1,\"Column\":33}}}]},{\"Case\":\"QsTupleItem\",\"Fields\":[{\"VariableName\":{\"Case\":\"ValidName\",\"Fields\":[\"b\"]},\"Type\":{\"Case\":\"Int\"},\"IsMutable\":false,\"HasLocalQuantumDependency\":false,\"Position\":{\"Case\":\"Null\"},\"Range\":{\"Item1\":{\"Line\":1,\"Column\":41},\"Item2\":{\"Line\":1,\"Column\":42}}}]},{\"Case\":\"QsTupleItem\",\"Fields\":[{\"VariableName\":{\"Case\":\"ValidName\",\"Fields\":[\"n\"]},\"Type\":{\"Case\":\"Int\"},\"IsMutable\":false,\"HasLocalQuantumDependency\":false,\"Position\":{\"Case\":\"Null\"},\"Range\":{\"Item1\":{\"Line\":1,\"Column\":50},\"Item2\":{\"Line\":1,\"Column\":51}}}]}]]},\"Signature\":{\"TypeParameters\":[],\"ArgumentType\":{\"Case\":\"TupleType\",\"Fields\":[[{\"Case\":\"Int\"},{\"Case\":\"Int\"},{\"Case\":\"Int\"}]]},\"ReturnType\":{\"Case\":\"Int\"},\"Information\":{\"Affiliation\":{\"Case\":\"EmptySet\"},\"InferredInformation\":{\"IsSelfAdjoint\":false,\"IsIntrinsic\":false}}},\"Documentation\":[]}")]
[assembly: SpecializationDeclaration("{\"Kind\":{\"Case\":\"QsBody\"},\"TypeArguments\":{\"Case\":\"Null\"},\"Information\":{\"Affiliation\":{\"Case\":\"EmptySet\"},\"InferredInformation\":{\"IsSelfAdjoint\":false,\"IsIntrinsic\":false}},\"Parent\":{\"Namespace\":\"Quantum.QSharpBasicArithmetics\",\"Name\":\"TestModularExponent\"},\"SourceFile\":\"C:/Demo/Quantum-Arithmetic-QSharp/QSharpBasicArithmetics/Operations.qs\",\"Position\":{\"Item1\":288,\"Item2\":4},\"HeaderRange\":{\"Item1\":{\"Line\":1,\"Column\":11},\"Item2\":{\"Line\":1,\"Column\":30}},\"Documentation\":[]}")]
[assembly: CallableDeclaration("{\"Kind\":{\"Case\":\"Operation\"},\"QualifiedName\":{\"Namespace\":\"Quantum.QSharpBasicArithmetics\",\"Name\":\"QFTImpl\"},\"SourceFile\":\"C:/Demo/Quantum-Arithmetic-QSharp/QSharpBasicArithmetics/Operations.qs\",\"Position\":{\"Item1\":330,\"Item2\":4},\"SymbolRange\":{\"Item1\":{\"Line\":1,\"Column\":11},\"Item2\":{\"Line\":1,\"Column\":18}},\"ArgumentTuple\":{\"Case\":\"QsTuple\",\"Fields\":[[{\"Case\":\"QsTupleItem\",\"Fields\":[{\"VariableName\":{\"Case\":\"ValidName\",\"Fields\":[\"qs\"]},\"Type\":{\"Case\":\"ArrayType\",\"Fields\":[{\"Case\":\"Qubit\"}]},\"IsMutable\":false,\"HasLocalQuantumDependency\":false,\"Position\":{\"Case\":\"Null\"},\"Range\":{\"Item1\":{\"Line\":1,\"Column\":20},\"Item2\":{\"Line\":1,\"Column\":22}}}]}]]},\"Signature\":{\"TypeParameters\":[],\"ArgumentType\":{\"Case\":\"ArrayType\",\"Fields\":[{\"Case\":\"Qubit\"}]},\"ReturnType\":{\"Case\":\"UnitType\"},\"Information\":{\"Affiliation\":{\"Case\":\"Union\",\"Fields\":[{\"Case\":\"SimpleSet\",\"Fields\":[{\"Case\":\"Adjointable\"}]},{\"Case\":\"SimpleSet\",\"Fields\":[{\"Case\":\"Controllable\"}]}]},\"InferredInformation\":{\"IsSelfAdjoint\":false,\"IsIntrinsic\":false}}},\"Documentation\":[]}")]
[assembly: SpecializationDeclaration("{\"Kind\":{\"Case\":\"QsBody\"},\"TypeArguments\":{\"Case\":\"Null\"},\"Information\":{\"Affiliation\":{\"Case\":\"Union\",\"Fields\":[{\"Case\":\"SimpleSet\",\"Fields\":[{\"Case\":\"Adjointable\"}]},{\"Case\":\"SimpleSet\",\"Fields\":[{\"Case\":\"Controllable\"}]}]},\"InferredInformation\":{\"IsSelfAdjoint\":false,\"IsIntrinsic\":false}},\"Parent\":{\"Namespace\":\"Quantum.QSharpBasicArithmetics\",\"Name\":\"QFTImpl\"},\"SourceFile\":\"C:/Demo/Quantum-Arithmetic-QSharp/QSharpBasicArithmetics/Operations.qs\",\"Position\":{\"Item1\":332,\"Item2\":8},\"HeaderRange\":{\"Item1\":{\"Line\":1,\"Column\":1},\"Item2\":{\"Line\":1,\"Column\":5}},\"Documentation\":[]}")]
[assembly: SpecializationDeclaration("{\"Kind\":{\"Case\":\"QsAdjoint\"},\"TypeArguments\":{\"Case\":\"Null\"},\"Information\":{\"Affiliation\":{\"Case\":\"Union\",\"Fields\":[{\"Case\":\"SimpleSet\",\"Fields\":[{\"Case\":\"Adjointable\"}]},{\"Case\":\"SimpleSet\",\"Fields\":[{\"Case\":\"Controllable\"}]}]},\"InferredInformation\":{\"IsSelfAdjoint\":false,\"IsIntrinsic\":false}},\"Parent\":{\"Namespace\":\"Quantum.QSharpBasicArithmetics\",\"Name\":\"QFTImpl\"},\"SourceFile\":\"C:/Demo/Quantum-Arithmetic-QSharp/QSharpBasicArithmetics/Operations.qs\",\"Position\":{\"Item1\":330,\"Item2\":4},\"HeaderRange\":{\"Item1\":{\"Line\":1,\"Column\":44},\"Item2\":{\"Line\":1,\"Column\":53}},\"Documentation\":[\"automatically generated QsAdjoint specialization for Quantum.QSharpBasicArithmetics.QFTImpl\"]}")]
[assembly: SpecializationDeclaration("{\"Kind\":{\"Case\":\"QsControlled\"},\"TypeArguments\":{\"Case\":\"Null\"},\"Information\":{\"Affiliation\":{\"Case\":\"Union\",\"Fields\":[{\"Case\":\"SimpleSet\",\"Fields\":[{\"Case\":\"Adjointable\"}]},{\"Case\":\"SimpleSet\",\"Fields\":[{\"Case\":\"Controllable\"}]}]},\"InferredInformation\":{\"IsSelfAdjoint\":false,\"IsIntrinsic\":false}},\"Parent\":{\"Namespace\":\"Quantum.QSharpBasicArithmetics\",\"Name\":\"QFTImpl\"},\"SourceFile\":\"C:/Demo/Quantum-Arithmetic-QSharp/QSharpBasicArithmetics/Operations.qs\",\"Position\":{\"Item1\":330,\"Item2\":4},\"HeaderRange\":{\"Item1\":{\"Line\":1,\"Column\":44},\"Item2\":{\"Line\":1,\"Column\":53}},\"Documentation\":[\"automatically generated QsControlled specialization for Quantum.QSharpBasicArithmetics.QFTImpl\"]}")]
[assembly: SpecializationDeclaration("{\"Kind\":{\"Case\":\"QsControlledAdjoint\"},\"TypeArguments\":{\"Case\":\"Null\"},\"Information\":{\"Affiliation\":{\"Case\":\"Union\",\"Fields\":[{\"Case\":\"SimpleSet\",\"Fields\":[{\"Case\":\"Adjointable\"}]},{\"Case\":\"SimpleSet\",\"Fields\":[{\"Case\":\"Controllable\"}]}]},\"InferredInformation\":{\"IsSelfAdjoint\":false,\"IsIntrinsic\":false}},\"Parent\":{\"Namespace\":\"Quantum.QSharpBasicArithmetics\",\"Name\":\"QFTImpl\"},\"SourceFile\":\"C:/Demo/Quantum-Arithmetic-QSharp/QSharpBasicArithmetics/Operations.qs\",\"Position\":{\"Item1\":330,\"Item2\":4},\"HeaderRange\":{\"Item1\":{\"Line\":1,\"Column\":44},\"Item2\":{\"Line\":1,\"Column\":53}},\"Documentation\":[\"automatically generated QsControlledAdjoint specialization for Quantum.QSharpBasicArithmetics.QFTImpl\"]}")]
#line hidden
namespace Quantum.QSharpBasicArithmetics
{
    public class ModularAdd : Unitary<(IQArray<Qubit>,IQArray<Qubit>)>, ICallable
    {
        public ModularAdd(IOperationFactory m) : base(m)
        {
        }

        public class In : QTuple<(IQArray<Qubit>,IQArray<Qubit>)>, IApplyData
        {
            public In((IQArray<Qubit>,IQArray<Qubit>) data) : base(data)
            {
            }

            System.Collections.Generic.IEnumerable<Qubit> IApplyData.Qubits => Qubit.Concat(((IApplyData)Data.Item1)?.Qubits, ((IApplyData)Data.Item2)?.Qubits);
        }

        String ICallable.Name => "ModularAdd";
        String ICallable.FullName => "Quantum.QSharpBasicArithmetics.ModularAdd";
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
            return __m__.Run<ModularAdd, (IQArray<Qubit>,IQArray<Qubit>), QVoid>((x, y));
        }
    }

    public class TestModularAdd : Operation<(Int64,Int64,Int64), Int64>, ICallable
    {
        public TestModularAdd(IOperationFactory m) : base(m)
        {
        }

        public class In : QTuple<(Int64,Int64,Int64)>, IApplyData
        {
            public In((Int64,Int64,Int64) data) : base(data)
            {
            }

            System.Collections.Generic.IEnumerable<Qubit> IApplyData.Qubits => null;
        }

        String ICallable.Name => "TestModularAdd";
        String ICallable.FullName => "Quantum.QSharpBasicArithmetics.TestModularAdd";
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

        protected IUnitary<(IQArray<Qubit>,IQArray<Qubit>)> ModularAdd
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
                    ModularAdd.Apply((x, y));
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
            this.ModularAdd = this.Factory.Get<IUnitary<(IQArray<Qubit>,IQArray<Qubit>)>>(typeof(ModularAdd));
        }

        public override IApplyData __dataIn((Int64,Int64,Int64) data) => new In(data);
        public override IApplyData __dataOut(Int64 data) => new QTuple<Int64>(data);
        public static System.Threading.Tasks.Task<Int64> Run(IOperationFactory __m__, Int64 a, Int64 b, Int64 n)
        {
            return __m__.Run<TestModularAdd, (Int64,Int64,Int64), Int64>((a, b, n));
        }
    }

    public class TestModularSub : Operation<(Int64,Int64,Int64), Int64>, ICallable
    {
        public TestModularSub(IOperationFactory m) : base(m)
        {
        }

        public class In : QTuple<(Int64,Int64,Int64)>, IApplyData
        {
            public In((Int64,Int64,Int64) data) : base(data)
            {
            }

            System.Collections.Generic.IEnumerable<Qubit> IApplyData.Qubits => null;
        }

        String ICallable.Name => "TestModularSub";
        String ICallable.FullName => "Quantum.QSharpBasicArithmetics.TestModularSub";
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

        protected IUnitary<(IQArray<Qubit>,IQArray<Qubit>)> ModularAdd
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
                    ModularAdd.Adjoint.Apply((x, y));
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
            this.ModularAdd = this.Factory.Get<IUnitary<(IQArray<Qubit>,IQArray<Qubit>)>>(typeof(ModularAdd));
        }

        public override IApplyData __dataIn((Int64,Int64,Int64) data) => new In(data);
        public override IApplyData __dataOut(Int64 data) => new QTuple<Int64>(data);
        public static System.Threading.Tasks.Task<Int64> Run(IOperationFactory __m__, Int64 a, Int64 b, Int64 n)
        {
            return __m__.Run<TestModularSub, (Int64,Int64,Int64), Int64>((a, b, n));
        }
    }

    public class ModularAddByNumber : Controllable<(IQArray<Qubit>,Int64)>, ICallable
    {
        public ModularAddByNumber(IOperationFactory m) : base(m)
        {
        }

        public class In : QTuple<(IQArray<Qubit>,Int64)>, IApplyData
        {
            public In((IQArray<Qubit>,Int64) data) : base(data)
            {
            }

            System.Collections.Generic.IEnumerable<Qubit> IApplyData.Qubits => ((IApplyData)Data.Item1)?.Qubits;
        }

        String ICallable.Name => "ModularAddByNumber";
        String ICallable.FullName => "Quantum.QSharpBasicArithmetics.ModularAddByNumber";
        protected ICallable Length
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
            var array2 = QArray<Boolean>.Create(n);
#line 136 "C:\\Demo\\Quantum-Arithmetic-QSharp\\QSharpBasicArithmetics\\Operations.qs"
            var tempInt2 = b;
#line 137 "C:\\Demo\\Quantum-Arithmetic-QSharp\\QSharpBasicArithmetics\\Operations.qs"
            foreach (var idxBit in new Range(0L, (n - 1L)))
#line hidden
            {
#line 138 "C:\\Demo\\Quantum-Arithmetic-QSharp\\QSharpBasicArithmetics\\Operations.qs"
                array2.Modify(((n - 1L) - idxBit), (((tempInt2 % 2L) == 0L) ? false : true));
#line 139 "C:\\Demo\\Quantum-Arithmetic-QSharp\\QSharpBasicArithmetics\\Operations.qs"
                tempInt2 = (tempInt2 / 2L);
            }

#line 143 "C:\\Demo\\Quantum-Arithmetic-QSharp\\QSharpBasicArithmetics\\Operations.qs"
            QFTImpl.Apply(x);
#line 144 "C:\\Demo\\Quantum-Arithmetic-QSharp\\QSharpBasicArithmetics\\Operations.qs"
            foreach (var i in new Range(0L, (n - 1L)))
#line hidden
            {
#line 145 "C:\\Demo\\Quantum-Arithmetic-QSharp\\QSharpBasicArithmetics\\Operations.qs"
                foreach (var j in new Range(0L, ((n - 1L) - i)))
#line hidden
                {
#line 146 "C:\\Demo\\Quantum-Arithmetic-QSharp\\QSharpBasicArithmetics\\Operations.qs"
                    if (array2[(i + j)])
                    {
#line 147 "C:\\Demo\\Quantum-Arithmetic-QSharp\\QSharpBasicArithmetics\\Operations.qs"
                        MicrosoftQuantumIntrinsicR1Frac.Apply((2L, (j + 1L), x[((n - 1L) - i)]));
                    }
                }
            }

#line 151 "C:\\Demo\\Quantum-Arithmetic-QSharp\\QSharpBasicArithmetics\\Operations.qs"
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
            var array2 = QArray<Boolean>.Create(n);
#line hidden
            var tempInt2 = b;
#line hidden
            foreach (var idxBit in new Range(0L, (n - 1L)))
#line hidden
            {
#line hidden
                array2.Modify(((n - 1L) - idxBit), (((tempInt2 % 2L) == 0L) ? false : true));
#line hidden
                tempInt2 = (tempInt2 / 2L);
            }

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
                    if (array2[(i + j)])
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
        public override void Init()
        {
            this.Length = this.Factory.Get<ICallable>(typeof(Microsoft.Quantum.Core.Length<>));
            this.MicrosoftQuantumIntrinsicR1Frac = this.Factory.Get<IUnitary<(Int64,Int64,Qubit)>>(typeof(Microsoft.Quantum.Intrinsic.R1Frac));
            this.QFTImpl = this.Factory.Get<IUnitary<IQArray<Qubit>>>(typeof(QFTImpl));
        }

        public override IApplyData __dataIn((IQArray<Qubit>,Int64) data) => new In(data);
        public override IApplyData __dataOut(QVoid data) => data;
        public static System.Threading.Tasks.Task<QVoid> Run(IOperationFactory __m__, IQArray<Qubit> x, Int64 b)
        {
            return __m__.Run<ModularAddByNumber, (IQArray<Qubit>,Int64), QVoid>((x, b));
        }
    }

    public class TestModularAddByNumber : Operation<(Int64,Int64,Int64), Int64>, ICallable
    {
        public TestModularAddByNumber(IOperationFactory m) : base(m)
        {
        }

        public class In : QTuple<(Int64,Int64,Int64)>, IApplyData
        {
            public In((Int64,Int64,Int64) data) : base(data)
            {
            }

            System.Collections.Generic.IEnumerable<Qubit> IApplyData.Qubits => null;
        }

        String ICallable.Name => "TestModularAddByNumber";
        String ICallable.FullName => "Quantum.QSharpBasicArithmetics.TestModularAddByNumber";
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

        protected IControllable<(IQArray<Qubit>,Int64)> ModularAddByNumber
        {
            get;
            set;
        }

        public override Func<(Int64,Int64,Int64), Int64> Body => (__in__) =>
        {
            var (a,b,n) = __in__;
#line 155 "C:\\Demo\\Quantum-Arithmetic-QSharp\\QSharpBasicArithmetics\\Operations.qs"
            var resultArray = QArray<Result>.Create(n);
#line hidden
            {
#line 157 "C:\\Demo\\Quantum-Arithmetic-QSharp\\QSharpBasicArithmetics\\Operations.qs"
                var x = Allocate.Apply(n);
#line hidden
                Exception __arg1__ = null;
                try
                {
#line 159 "C:\\Demo\\Quantum-Arithmetic-QSharp\\QSharpBasicArithmetics\\Operations.qs"
                    var array1 = QArray<Boolean>.Create(n);
#line 160 "C:\\Demo\\Quantum-Arithmetic-QSharp\\QSharpBasicArithmetics\\Operations.qs"
                    var tempInt1 = a;
#line 161 "C:\\Demo\\Quantum-Arithmetic-QSharp\\QSharpBasicArithmetics\\Operations.qs"
                    foreach (var idxBit in new Range(0L, (n - 1L)))
#line hidden
                    {
#line 162 "C:\\Demo\\Quantum-Arithmetic-QSharp\\QSharpBasicArithmetics\\Operations.qs"
                        array1.Modify(((n - 1L) - idxBit), (((tempInt1 % 2L) == 0L) ? false : true));
#line 163 "C:\\Demo\\Quantum-Arithmetic-QSharp\\QSharpBasicArithmetics\\Operations.qs"
                        tempInt1 = (tempInt1 / 2L);
                    }

#line 165 "C:\\Demo\\Quantum-Arithmetic-QSharp\\QSharpBasicArithmetics\\Operations.qs"
                    foreach (var idx in new Range(0L, (n - 1L)))
#line hidden
                    {
#line 166 "C:\\Demo\\Quantum-Arithmetic-QSharp\\QSharpBasicArithmetics\\Operations.qs"
                        if (array1[idx])
                        {
#line 167 "C:\\Demo\\Quantum-Arithmetic-QSharp\\QSharpBasicArithmetics\\Operations.qs"
                            MicrosoftQuantumIntrinsicX.Apply(x[idx]);
                        }
                    }

#line 172 "C:\\Demo\\Quantum-Arithmetic-QSharp\\QSharpBasicArithmetics\\Operations.qs"
                    ModularAddByNumber.Apply((x, b));
#line 175 "C:\\Demo\\Quantum-Arithmetic-QSharp\\QSharpBasicArithmetics\\Operations.qs"
                    foreach (var idx in new Range(0L, (n - 1L)))
#line hidden
                    {
#line 176 "C:\\Demo\\Quantum-Arithmetic-QSharp\\QSharpBasicArithmetics\\Operations.qs"
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

#line 181 "C:\\Demo\\Quantum-Arithmetic-QSharp\\QSharpBasicArithmetics\\Operations.qs"
            var resultBool = (IQArray<Boolean>)MicrosoftQuantumConvertResultArrayAsBoolArray.Apply(resultArray?.Copy());
#line 182 "C:\\Demo\\Quantum-Arithmetic-QSharp\\QSharpBasicArithmetics\\Operations.qs"
            var resultInt = 0L;
#line 183 "C:\\Demo\\Quantum-Arithmetic-QSharp\\QSharpBasicArithmetics\\Operations.qs"
            foreach (var idx in new Range(0L, (n - 1L)))
#line hidden
            {
#line 184 "C:\\Demo\\Quantum-Arithmetic-QSharp\\QSharpBasicArithmetics\\Operations.qs"
                if (resultBool[idx])
                {
#line 185 "C:\\Demo\\Quantum-Arithmetic-QSharp\\QSharpBasicArithmetics\\Operations.qs"
                    resultInt = (resultInt + 2L.Pow(((n - 1L) - idx)));
                }
            }

#line 188 "C:\\Demo\\Quantum-Arithmetic-QSharp\\QSharpBasicArithmetics\\Operations.qs"
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
            this.ModularAddByNumber = this.Factory.Get<IControllable<(IQArray<Qubit>,Int64)>>(typeof(ModularAddByNumber));
        }

        public override IApplyData __dataIn((Int64,Int64,Int64) data) => new In(data);
        public override IApplyData __dataOut(Int64 data) => new QTuple<Int64>(data);
        public static System.Threading.Tasks.Task<Int64> Run(IOperationFactory __m__, Int64 a, Int64 b, Int64 n)
        {
            return __m__.Run<TestModularAddByNumber, (Int64,Int64,Int64), Int64>((a, b, n));
        }
    }

    public class ModularMultiply : Unitary<(Int64,IQArray<Qubit>)>, ICallable
    {
        public ModularMultiply(IOperationFactory m) : base(m)
        {
        }

        public class In : QTuple<(Int64,IQArray<Qubit>)>, IApplyData
        {
            public In((Int64,IQArray<Qubit>) data) : base(data)
            {
            }

            System.Collections.Generic.IEnumerable<Qubit> IApplyData.Qubits => ((IApplyData)Data.Item2)?.Qubits;
        }

        String ICallable.Name => "ModularMultiply";
        String ICallable.FullName => "Quantum.QSharpBasicArithmetics.ModularMultiply";
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

        protected IUnitary<(IQArray<Qubit>,IQArray<Qubit>)> ModularAdd
        {
            get;
            set;
        }

        public override Func<(Int64,IQArray<Qubit>), QVoid> Body => (__in__) =>
        {
            var (a,y) = __in__;
#line 199 "C:\\Demo\\Quantum-Arithmetic-QSharp\\QSharpBasicArithmetics\\Operations.qs"
            var n = y.Length;
#line 200 "C:\\Demo\\Quantum-Arithmetic-QSharp\\QSharpBasicArithmetics\\Operations.qs"
            var a_mod = (a % 2L.Pow(n));
#line hidden
            {
#line 202 "C:\\Demo\\Quantum-Arithmetic-QSharp\\QSharpBasicArithmetics\\Operations.qs"
                var s = Allocate.Apply(n);
#line hidden
                Exception __arg1__ = null;
                try
                {
#line 206 "C:\\Demo\\Quantum-Arithmetic-QSharp\\QSharpBasicArithmetics\\Operations.qs"
                    foreach (var r in new Range(0L, (a_mod - 1L)))
#line hidden
                    {
#line 207 "C:\\Demo\\Quantum-Arithmetic-QSharp\\QSharpBasicArithmetics\\Operations.qs"
                        ModularAdd.Apply((y, s));
                    }

#line 212 "C:\\Demo\\Quantum-Arithmetic-QSharp\\QSharpBasicArithmetics\\Operations.qs"
                    MicrosoftQuantumCanonApplyToEachCA.Apply((MicrosoftQuantumIntrinsicSWAP, MicrosoftQuantumArraysZip.Apply<IQArray<(Qubit,Qubit)>>((y, s))));
#line 217 "C:\\Demo\\Quantum-Arithmetic-QSharp\\QSharpBasicArithmetics\\Operations.qs"
                    var a_inv = MicrosoftQuantumMathInverseModI.Apply((a_mod, 2L.Pow(n)));
#line 218 "C:\\Demo\\Quantum-Arithmetic-QSharp\\QSharpBasicArithmetics\\Operations.qs"
                    foreach (var r in new Range(0L, (a_inv - 1L)))
#line hidden
                    {
#line 219 "C:\\Demo\\Quantum-Arithmetic-QSharp\\QSharpBasicArithmetics\\Operations.qs"
                        ModularAdd.Adjoint.Apply((y, s));
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
                        ModularAdd.Adjoint.Adjoint.Apply((y, s));
                    }

#line hidden
                    MicrosoftQuantumCanonApplyToEachCA.Adjoint.Apply((MicrosoftQuantumIntrinsicSWAP, MicrosoftQuantumArraysZip.Apply<IQArray<(Qubit,Qubit)>>((y, s))));
#line hidden
                    foreach (var r in RangeReverse.Apply(new Range(0L, (a_mod - 1L))))
#line hidden
                    {
#line hidden
                        ModularAdd.Adjoint.Apply((y, s));
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
                        ModularAdd.Controlled.Apply((__controlQubits__, (y, s)));
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
                        ModularAdd.Adjoint.Controlled.Apply((__controlQubits__, (y, s)));
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
                        ModularAdd.Adjoint.Adjoint.Controlled.Apply((__controlQubits__, (y, s)));
                    }

#line hidden
                    MicrosoftQuantumCanonApplyToEachCA.Adjoint.Controlled.Apply((__controlQubits__, (MicrosoftQuantumIntrinsicSWAP, MicrosoftQuantumArraysZip.Apply<IQArray<(Qubit,Qubit)>>((y, s)))));
#line hidden
                    foreach (var r in RangeReverse.Apply(new Range(0L, (a_mod - 1L))))
#line hidden
                    {
#line hidden
                        ModularAdd.Adjoint.Controlled.Apply((__controlQubits__, (y, s)));
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
            this.ModularAdd = this.Factory.Get<IUnitary<(IQArray<Qubit>,IQArray<Qubit>)>>(typeof(ModularAdd));
        }

        public override IApplyData __dataIn((Int64,IQArray<Qubit>) data) => new In(data);
        public override IApplyData __dataOut(QVoid data) => data;
        public static System.Threading.Tasks.Task<QVoid> Run(IOperationFactory __m__, Int64 a, IQArray<Qubit> y)
        {
            return __m__.Run<ModularMultiply, (Int64,IQArray<Qubit>), QVoid>((a, y));
        }
    }

    public class TestModularMultiply : Operation<(Int64,Int64,Int64), Int64>, ICallable
    {
        public TestModularMultiply(IOperationFactory m) : base(m)
        {
        }

        public class In : QTuple<(Int64,Int64,Int64)>, IApplyData
        {
            public In((Int64,Int64,Int64) data) : base(data)
            {
            }

            System.Collections.Generic.IEnumerable<Qubit> IApplyData.Qubits => null;
        }

        String ICallable.Name => "TestModularMultiply";
        String ICallable.FullName => "Quantum.QSharpBasicArithmetics.TestModularMultiply";
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

        protected IUnitary<(Int64,IQArray<Qubit>)> ModularMultiply
        {
            get;
            set;
        }

        public override Func<(Int64,Int64,Int64), Int64> Body => (__in__) =>
        {
            var (a,b,n) = __in__;
#line 225 "C:\\Demo\\Quantum-Arithmetic-QSharp\\QSharpBasicArithmetics\\Operations.qs"
            var resultArray = QArray<Result>.Create(n);
#line hidden
            {
#line 227 "C:\\Demo\\Quantum-Arithmetic-QSharp\\QSharpBasicArithmetics\\Operations.qs"
                var y = Allocate.Apply(n);
#line hidden
                Exception __arg1__ = null;
                try
                {
#line 229 "C:\\Demo\\Quantum-Arithmetic-QSharp\\QSharpBasicArithmetics\\Operations.qs"
                    var array2 = QArray<Boolean>.Create(n);
#line 230 "C:\\Demo\\Quantum-Arithmetic-QSharp\\QSharpBasicArithmetics\\Operations.qs"
                    var tempInt2 = b;
#line 231 "C:\\Demo\\Quantum-Arithmetic-QSharp\\QSharpBasicArithmetics\\Operations.qs"
                    foreach (var idxBit in new Range(0L, (n - 1L)))
#line hidden
                    {
#line 232 "C:\\Demo\\Quantum-Arithmetic-QSharp\\QSharpBasicArithmetics\\Operations.qs"
                        array2.Modify(((n - 1L) - idxBit), (((tempInt2 % 2L) == 0L) ? false : true));
#line 233 "C:\\Demo\\Quantum-Arithmetic-QSharp\\QSharpBasicArithmetics\\Operations.qs"
                        tempInt2 = (tempInt2 / 2L);
                    }

#line 235 "C:\\Demo\\Quantum-Arithmetic-QSharp\\QSharpBasicArithmetics\\Operations.qs"
                    foreach (var idx in new Range(0L, (n - 1L)))
#line hidden
                    {
#line 236 "C:\\Demo\\Quantum-Arithmetic-QSharp\\QSharpBasicArithmetics\\Operations.qs"
                        if (array2[idx])
                        {
#line 237 "C:\\Demo\\Quantum-Arithmetic-QSharp\\QSharpBasicArithmetics\\Operations.qs"
                            MicrosoftQuantumIntrinsicX.Apply(y[idx]);
                        }
                    }

#line 242 "C:\\Demo\\Quantum-Arithmetic-QSharp\\QSharpBasicArithmetics\\Operations.qs"
                    ModularMultiply.Apply((a, y));
#line 245 "C:\\Demo\\Quantum-Arithmetic-QSharp\\QSharpBasicArithmetics\\Operations.qs"
                    foreach (var idx in new Range(0L, (n - 1L)))
#line hidden
                    {
#line 246 "C:\\Demo\\Quantum-Arithmetic-QSharp\\QSharpBasicArithmetics\\Operations.qs"
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

#line 251 "C:\\Demo\\Quantum-Arithmetic-QSharp\\QSharpBasicArithmetics\\Operations.qs"
            var resultBool = (IQArray<Boolean>)MicrosoftQuantumConvertResultArrayAsBoolArray.Apply(resultArray?.Copy());
#line 252 "C:\\Demo\\Quantum-Arithmetic-QSharp\\QSharpBasicArithmetics\\Operations.qs"
            var resultInt = 0L;
#line 253 "C:\\Demo\\Quantum-Arithmetic-QSharp\\QSharpBasicArithmetics\\Operations.qs"
            foreach (var idx in new Range(0L, (n - 1L)))
#line hidden
            {
#line 254 "C:\\Demo\\Quantum-Arithmetic-QSharp\\QSharpBasicArithmetics\\Operations.qs"
                if (resultBool[idx])
                {
#line 255 "C:\\Demo\\Quantum-Arithmetic-QSharp\\QSharpBasicArithmetics\\Operations.qs"
                    resultInt = (resultInt + 2L.Pow(((n - 1L) - idx)));
                }
            }

#line 258 "C:\\Demo\\Quantum-Arithmetic-QSharp\\QSharpBasicArithmetics\\Operations.qs"
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
            this.ModularMultiply = this.Factory.Get<IUnitary<(Int64,IQArray<Qubit>)>>(typeof(ModularMultiply));
        }

        public override IApplyData __dataIn((Int64,Int64,Int64) data) => new In(data);
        public override IApplyData __dataOut(Int64 data) => new QTuple<Int64>(data);
        public static System.Threading.Tasks.Task<Int64> Run(IOperationFactory __m__, Int64 a, Int64 b, Int64 n)
        {
            return __m__.Run<TestModularMultiply, (Int64,Int64,Int64), Int64>((a, b, n));
        }
    }

    public class ModularExponent : Operation<(Int64,IQArray<Qubit>), QVoid>, ICallable
    {
        public ModularExponent(IOperationFactory m) : base(m)
        {
        }

        public class In : QTuple<(Int64,IQArray<Qubit>)>, IApplyData
        {
            public In((Int64,IQArray<Qubit>) data) : base(data)
            {
            }

            System.Collections.Generic.IEnumerable<Qubit> IApplyData.Qubits => ((IApplyData)Data.Item2)?.Qubits;
        }

        String ICallable.Name => "ModularExponent";
        String ICallable.FullName => "Quantum.QSharpBasicArithmetics.ModularExponent";
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

        protected IUnitary<(Int64,IQArray<Qubit>)> ModularMultiply
        {
            get;
            set;
        }

        public override Func<(Int64,IQArray<Qubit>), QVoid> Body => (__in__) =>
        {
            var (a,x) = __in__;
#line 269 "C:\\Demo\\Quantum-Arithmetic-QSharp\\QSharpBasicArithmetics\\Operations.qs"
            var n = x.Length;
#line hidden
            {
#line 270 "C:\\Demo\\Quantum-Arithmetic-QSharp\\QSharpBasicArithmetics\\Operations.qs"
                var s = Allocate.Apply(n);
#line hidden
                Exception __arg1__ = null;
                try
                {
#line 272 "C:\\Demo\\Quantum-Arithmetic-QSharp\\QSharpBasicArithmetics\\Operations.qs"
                    MicrosoftQuantumIntrinsicX.Apply(s[(n - 1L)]);
#line 275 "C:\\Demo\\Quantum-Arithmetic-QSharp\\QSharpBasicArithmetics\\Operations.qs"
                    foreach (var idx in new Range(0L, (n - 1L)))
#line hidden
                    {
#line 276 "C:\\Demo\\Quantum-Arithmetic-QSharp\\QSharpBasicArithmetics\\Operations.qs"
                        ModularMultiply.Controlled.Apply((new QArray<Qubit>(x[idx]), (a.Pow(2L.Pow(((n - 1L) - idx))), s)));
                    }

#line 280 "C:\\Demo\\Quantum-Arithmetic-QSharp\\QSharpBasicArithmetics\\Operations.qs"
                    MicrosoftQuantumCanonApplyToEachCA.Apply((MicrosoftQuantumIntrinsicSWAP, MicrosoftQuantumArraysZip.Apply<IQArray<(Qubit,Qubit)>>((x, s))));
#line 283 "C:\\Demo\\Quantum-Arithmetic-QSharp\\QSharpBasicArithmetics\\Operations.qs"
                    foreach (var idx in new Range(0L, (n - 1L)))
#line hidden
                    {
#line 284 "C:\\Demo\\Quantum-Arithmetic-QSharp\\QSharpBasicArithmetics\\Operations.qs"
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
            this.ModularMultiply = this.Factory.Get<IUnitary<(Int64,IQArray<Qubit>)>>(typeof(ModularMultiply));
        }

        public override IApplyData __dataIn((Int64,IQArray<Qubit>) data) => new In(data);
        public override IApplyData __dataOut(QVoid data) => data;
        public static System.Threading.Tasks.Task<QVoid> Run(IOperationFactory __m__, Int64 a, IQArray<Qubit> x)
        {
            return __m__.Run<ModularExponent, (Int64,IQArray<Qubit>), QVoid>((a, x));
        }
    }

    public class TestModularExponent : Operation<(Int64,Int64,Int64), Int64>, ICallable
    {
        public TestModularExponent(IOperationFactory m) : base(m)
        {
        }

        public class In : QTuple<(Int64,Int64,Int64)>, IApplyData
        {
            public In((Int64,Int64,Int64) data) : base(data)
            {
            }

            System.Collections.Generic.IEnumerable<Qubit> IApplyData.Qubits => null;
        }

        String ICallable.Name => "TestModularExponent";
        String ICallable.FullName => "Quantum.QSharpBasicArithmetics.TestModularExponent";
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

        protected ICallable<(Int64,IQArray<Qubit>), QVoid> ModularExponent
        {
            get;
            set;
        }

        public override Func<(Int64,Int64,Int64), Int64> Body => (__in__) =>
        {
            var (a,b,n) = __in__;
#line 290 "C:\\Demo\\Quantum-Arithmetic-QSharp\\QSharpBasicArithmetics\\Operations.qs"
            var resultArray = QArray<Result>.Create(n);
#line hidden
            {
#line 292 "C:\\Demo\\Quantum-Arithmetic-QSharp\\QSharpBasicArithmetics\\Operations.qs"
                var x = Allocate.Apply(n);
#line hidden
                Exception __arg1__ = null;
                try
                {
#line 294 "C:\\Demo\\Quantum-Arithmetic-QSharp\\QSharpBasicArithmetics\\Operations.qs"
                    var array2 = QArray<Boolean>.Create(n);
#line 295 "C:\\Demo\\Quantum-Arithmetic-QSharp\\QSharpBasicArithmetics\\Operations.qs"
                    var tempInt2 = b;
#line 296 "C:\\Demo\\Quantum-Arithmetic-QSharp\\QSharpBasicArithmetics\\Operations.qs"
                    foreach (var idxBit in new Range(0L, (n - 1L)))
#line hidden
                    {
#line 297 "C:\\Demo\\Quantum-Arithmetic-QSharp\\QSharpBasicArithmetics\\Operations.qs"
                        array2.Modify(((n - 1L) - idxBit), (((tempInt2 % 2L) == 0L) ? false : true));
#line 298 "C:\\Demo\\Quantum-Arithmetic-QSharp\\QSharpBasicArithmetics\\Operations.qs"
                        tempInt2 = (tempInt2 / 2L);
                    }

#line 300 "C:\\Demo\\Quantum-Arithmetic-QSharp\\QSharpBasicArithmetics\\Operations.qs"
                    foreach (var idx in new Range(0L, (n - 1L)))
#line hidden
                    {
#line 301 "C:\\Demo\\Quantum-Arithmetic-QSharp\\QSharpBasicArithmetics\\Operations.qs"
                        if (array2[idx])
                        {
#line 302 "C:\\Demo\\Quantum-Arithmetic-QSharp\\QSharpBasicArithmetics\\Operations.qs"
                            MicrosoftQuantumIntrinsicX.Apply(x[idx]);
                        }
                    }

#line 307 "C:\\Demo\\Quantum-Arithmetic-QSharp\\QSharpBasicArithmetics\\Operations.qs"
                    ModularExponent.Apply((a, x));
#line 310 "C:\\Demo\\Quantum-Arithmetic-QSharp\\QSharpBasicArithmetics\\Operations.qs"
                    foreach (var idx in new Range(0L, (n - 1L)))
#line hidden
                    {
#line 311 "C:\\Demo\\Quantum-Arithmetic-QSharp\\QSharpBasicArithmetics\\Operations.qs"
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

#line 316 "C:\\Demo\\Quantum-Arithmetic-QSharp\\QSharpBasicArithmetics\\Operations.qs"
            var resultBool = (IQArray<Boolean>)MicrosoftQuantumConvertResultArrayAsBoolArray.Apply(resultArray?.Copy());
#line 317 "C:\\Demo\\Quantum-Arithmetic-QSharp\\QSharpBasicArithmetics\\Operations.qs"
            var resultInt = 0L;
#line 318 "C:\\Demo\\Quantum-Arithmetic-QSharp\\QSharpBasicArithmetics\\Operations.qs"
            foreach (var idx in new Range(0L, (n - 1L)))
#line hidden
            {
#line 319 "C:\\Demo\\Quantum-Arithmetic-QSharp\\QSharpBasicArithmetics\\Operations.qs"
                if (resultBool[idx])
                {
#line 320 "C:\\Demo\\Quantum-Arithmetic-QSharp\\QSharpBasicArithmetics\\Operations.qs"
                    resultInt = (resultInt + 2L.Pow(((n - 1L) - idx)));
                }
            }

#line 323 "C:\\Demo\\Quantum-Arithmetic-QSharp\\QSharpBasicArithmetics\\Operations.qs"
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
            this.ModularExponent = this.Factory.Get<ICallable<(Int64,IQArray<Qubit>), QVoid>>(typeof(ModularExponent));
        }

        public override IApplyData __dataIn((Int64,Int64,Int64) data) => new In(data);
        public override IApplyData __dataOut(Int64 data) => new QTuple<Int64>(data);
        public static System.Threading.Tasks.Task<Int64> Run(IOperationFactory __m__, Int64 a, Int64 b, Int64 n)
        {
            return __m__.Run<TestModularExponent, (Int64,Int64,Int64), Int64>((a, b, n));
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
#line 335 "C:\\Demo\\Quantum-Arithmetic-QSharp\\QSharpBasicArithmetics\\Operations.qs"
            var nQubits = qs.Length;
#line 337 "C:\\Demo\\Quantum-Arithmetic-QSharp\\QSharpBasicArithmetics\\Operations.qs"
            foreach (var i in new Range(0L, (nQubits - 1L)))
#line hidden
            {
#line 339 "C:\\Demo\\Quantum-Arithmetic-QSharp\\QSharpBasicArithmetics\\Operations.qs"
                MicrosoftQuantumIntrinsicH.Apply(qs[i]);
#line 340 "C:\\Demo\\Quantum-Arithmetic-QSharp\\QSharpBasicArithmetics\\Operations.qs"
                foreach (var j in new Range((i + 1L), (nQubits - 1L)))
#line hidden
                {
#line 342 "C:\\Demo\\Quantum-Arithmetic-QSharp\\QSharpBasicArithmetics\\Operations.qs"
                    MicrosoftQuantumIntrinsicR1Frac.Controlled.Apply((new QArray<Qubit>(qs[j]), (1L, (j - i), qs[i])));
                }
            }

#line 346 "C:\\Demo\\Quantum-Arithmetic-QSharp\\QSharpBasicArithmetics\\Operations.qs"
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