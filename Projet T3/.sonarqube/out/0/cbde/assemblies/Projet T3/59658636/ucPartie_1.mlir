// Skipping function btnParticipe_Click(none, none), it contains poisonous unsupported syntaxes

// Skipping function faireAction(none), it contains poisonous unsupported syntaxes

// Skipping function majMerite(i32), it contains poisonous unsupported syntaxes

// Skipping function majCompetence(i32), it contains poisonous unsupported syntaxes

func @_Projet_T3.ucPartie.calculeMerite$int$(i32) -> i32 loc("C:\\Users\\fanny\\OneDrive\\cours\\INFO\\S3\\T3\\Projet T3\\Projet T3\\ucPartie.cs" :357 :8) {
^entry (%_action : i32):
%0 = cbde.alloca i32 loc("C:\\Users\\fanny\\OneDrive\\cours\\INFO\\S3\\T3\\Projet T3\\Projet T3\\ucPartie.cs" :357 :34)
cbde.store %_action, %0 : memref<i32> loc("C:\\Users\\fanny\\OneDrive\\cours\\INFO\\S3\\T3\\Projet T3\\Projet T3\\ucPartie.cs" :357 :34)
br ^0

^0: // BinaryBranchBlock
// Entity from another assembly: Convert
%1 = cbde.unknown : none loc("C:\\Users\\fanny\\OneDrive\\cours\\INFO\\S3\\T3\\Projet T3\\Projet T3\\ucPartie.cs" :359 :38) // Not a variable of known type: dsLocal
%2 = cbde.unknown : none loc("C:\\Users\\fanny\\OneDrive\\cours\\INFO\\S3\\T3\\Projet T3\\Projet T3\\ucPartie.cs" :359 :38) // dsLocal.Tables (SimpleMemberAccessExpression)
%3 = cbde.unknown : none loc("C:\\Users\\fanny\\OneDrive\\cours\\INFO\\S3\\T3\\Projet T3\\Projet T3\\ucPartie.cs" :359 :53) // "cours" (StringLiteralExpression)
%4 = cbde.unknown : none loc("C:\\Users\\fanny\\OneDrive\\cours\\INFO\\S3\\T3\\Projet T3\\Projet T3\\ucPartie.cs" :359 :38) // dsLocal.Tables["cours"] (ElementAccessExpression)
%5 = cbde.unknown : none loc("C:\\Users\\fanny\\OneDrive\\cours\\INFO\\S3\\T3\\Projet T3\\Projet T3\\ucPartie.cs" :359 :38) // dsLocal.Tables["cours"].Rows (SimpleMemberAccessExpression)
%6 = cbde.unknown : i32 loc("C:\\Users\\fanny\\OneDrive\\cours\\INFO\\S3\\T3\\Projet T3\\Projet T3\\ucPartie.cs" :359 :67) // Not a variable of known type: idProf
%7 = cbde.unknown : none loc("C:\\Users\\fanny\\OneDrive\\cours\\INFO\\S3\\T3\\Projet T3\\Projet T3\\ucPartie.cs" :359 :38) // dsLocal.Tables["cours"].Rows[idProf] (ElementAccessExpression)
%8 = constant 2 : i32 loc("C:\\Users\\fanny\\OneDrive\\cours\\INFO\\S3\\T3\\Projet T3\\Projet T3\\ucPartie.cs" :359 :75)
%9 = cbde.unknown : none loc("C:\\Users\\fanny\\OneDrive\\cours\\INFO\\S3\\T3\\Projet T3\\Projet T3\\ucPartie.cs" :359 :38) // dsLocal.Tables["cours"].Rows[idProf][2] (ElementAccessExpression)
%10 = cbde.unknown : i32 loc("C:\\Users\\fanny\\OneDrive\\cours\\INFO\\S3\\T3\\Projet T3\\Projet T3\\ucPartie.cs" :359 :22) // Convert.ToInt32(dsLocal.Tables["cours"].Rows[idProf][2]) (InvocationExpression)
%11 = cbde.alloca i32 loc("C:\\Users\\fanny\\OneDrive\\cours\\INFO\\S3\\T3\\Projet T3\\Projet T3\\ucPartie.cs" :359 :16) // res
cbde.store %10, %11 : memref<i32> loc("C:\\Users\\fanny\\OneDrive\\cours\\INFO\\S3\\T3\\Projet T3\\Projet T3\\ucPartie.cs" :359 :16)
%12 = cbde.load %0 : memref<i32> loc("C:\\Users\\fanny\\OneDrive\\cours\\INFO\\S3\\T3\\Projet T3\\Projet T3\\ucPartie.cs" :360 :16)
%13 = constant 0 : i32 loc("C:\\Users\\fanny\\OneDrive\\cours\\INFO\\S3\\T3\\Projet T3\\Projet T3\\ucPartie.cs" :360 :26)
%14 = cmpi "eq", %12, %13 : i32 loc("C:\\Users\\fanny\\OneDrive\\cours\\INFO\\S3\\T3\\Projet T3\\Projet T3\\ucPartie.cs" :360 :16)
cond_br %14, ^1, ^2 loc("C:\\Users\\fanny\\OneDrive\\cours\\INFO\\S3\\T3\\Projet T3\\Projet T3\\ucPartie.cs" :360 :16)

^1: // SimpleBlock
%15 = cbde.load %11 : memref<i32> loc("C:\\Users\\fanny\\OneDrive\\cours\\INFO\\S3\\T3\\Projet T3\\Projet T3\\ucPartie.cs" :361 :16)
%16 = constant 25 : i32 loc("C:\\Users\\fanny\\OneDrive\\cours\\INFO\\S3\\T3\\Projet T3\\Projet T3\\ucPartie.cs" :361 :23)
%17 = addi %15, %16 : i32 loc("C:\\Users\\fanny\\OneDrive\\cours\\INFO\\S3\\T3\\Projet T3\\Projet T3\\ucPartie.cs" :361 :16)
cbde.store %17, %11 : memref<i32> loc("C:\\Users\\fanny\\OneDrive\\cours\\INFO\\S3\\T3\\Projet T3\\Projet T3\\ucPartie.cs" :361 :16)
br ^2

^2: // BinaryBranchBlock
%18 = cbde.load %0 : memref<i32> loc("C:\\Users\\fanny\\OneDrive\\cours\\INFO\\S3\\T3\\Projet T3\\Projet T3\\ucPartie.cs" :362 :16)
%19 = constant 1 : i32 loc("C:\\Users\\fanny\\OneDrive\\cours\\INFO\\S3\\T3\\Projet T3\\Projet T3\\ucPartie.cs" :362 :26)
%20 = cmpi "eq", %18, %19 : i32 loc("C:\\Users\\fanny\\OneDrive\\cours\\INFO\\S3\\T3\\Projet T3\\Projet T3\\ucPartie.cs" :362 :16)
cond_br %20, ^3, ^4 loc("C:\\Users\\fanny\\OneDrive\\cours\\INFO\\S3\\T3\\Projet T3\\Projet T3\\ucPartie.cs" :362 :16)

^3: // SimpleBlock
%21 = cbde.load %11 : memref<i32> loc("C:\\Users\\fanny\\OneDrive\\cours\\INFO\\S3\\T3\\Projet T3\\Projet T3\\ucPartie.cs" :363 :16)
%22 = constant 25 : i32 loc("C:\\Users\\fanny\\OneDrive\\cours\\INFO\\S3\\T3\\Projet T3\\Projet T3\\ucPartie.cs" :363 :23)
%23 = subi %21, %22 : i32 loc("C:\\Users\\fanny\\OneDrive\\cours\\INFO\\S3\\T3\\Projet T3\\Projet T3\\ucPartie.cs" :363 :16)
cbde.store %23, %11 : memref<i32> loc("C:\\Users\\fanny\\OneDrive\\cours\\INFO\\S3\\T3\\Projet T3\\Projet T3\\ucPartie.cs" :363 :16)
br ^4

^4: // BinaryBranchBlock
%24 = cbde.load %11 : memref<i32> loc("C:\\Users\\fanny\\OneDrive\\cours\\INFO\\S3\\T3\\Projet T3\\Projet T3\\ucPartie.cs" :366 :16)
%25 = constant 0 : i32 loc("C:\\Users\\fanny\\OneDrive\\cours\\INFO\\S3\\T3\\Projet T3\\Projet T3\\ucPartie.cs" :366 :22)
%26 = cmpi "slt", %24, %25 : i32 loc("C:\\Users\\fanny\\OneDrive\\cours\\INFO\\S3\\T3\\Projet T3\\Projet T3\\ucPartie.cs" :366 :16)
cond_br %26, ^5, ^6 loc("C:\\Users\\fanny\\OneDrive\\cours\\INFO\\S3\\T3\\Projet T3\\Projet T3\\ucPartie.cs" :366 :16)

^5: // SimpleBlock
%27 = constant 0 : i32 loc("C:\\Users\\fanny\\OneDrive\\cours\\INFO\\S3\\T3\\Projet T3\\Projet T3\\ucPartie.cs" :367 :22)
cbde.store %27, %11 : memref<i32> loc("C:\\Users\\fanny\\OneDrive\\cours\\INFO\\S3\\T3\\Projet T3\\Projet T3\\ucPartie.cs" :367 :16)
br ^6

^6: // BinaryBranchBlock
%28 = cbde.load %11 : memref<i32> loc("C:\\Users\\fanny\\OneDrive\\cours\\INFO\\S3\\T3\\Projet T3\\Projet T3\\ucPartie.cs" :368 :16)
%29 = constant 100 : i32 loc("C:\\Users\\fanny\\OneDrive\\cours\\INFO\\S3\\T3\\Projet T3\\Projet T3\\ucPartie.cs" :368 :22)
%30 = cmpi "sgt", %28, %29 : i32 loc("C:\\Users\\fanny\\OneDrive\\cours\\INFO\\S3\\T3\\Projet T3\\Projet T3\\ucPartie.cs" :368 :16)
cond_br %30, ^7, ^8 loc("C:\\Users\\fanny\\OneDrive\\cours\\INFO\\S3\\T3\\Projet T3\\Projet T3\\ucPartie.cs" :368 :16)

^7: // SimpleBlock
%31 = constant 100 : i32 loc("C:\\Users\\fanny\\OneDrive\\cours\\INFO\\S3\\T3\\Projet T3\\Projet T3\\ucPartie.cs" :369 :22)
cbde.store %31, %11 : memref<i32> loc("C:\\Users\\fanny\\OneDrive\\cours\\INFO\\S3\\T3\\Projet T3\\Projet T3\\ucPartie.cs" :369 :16)
br ^8

^8: // JumpBlock
%32 = cbde.load %11 : memref<i32> loc("C:\\Users\\fanny\\OneDrive\\cours\\INFO\\S3\\T3\\Projet T3\\Projet T3\\ucPartie.cs" :370 :19)
return %32 : i32 loc("C:\\Users\\fanny\\OneDrive\\cours\\INFO\\S3\\T3\\Projet T3\\Projet T3\\ucPartie.cs" :370 :12)

^9: // ExitBlock
cbde.unreachable

}
func @_Projet_T3.ucPartie.calculeCompetence$int$(i32) -> i32 loc("C:\\Users\\fanny\\OneDrive\\cours\\INFO\\S3\\T3\\Projet T3\\Projet T3\\ucPartie.cs" :378 :8) {
^entry (%_action : i32):
%0 = cbde.alloca i32 loc("C:\\Users\\fanny\\OneDrive\\cours\\INFO\\S3\\T3\\Projet T3\\Projet T3\\ucPartie.cs" :378 :38)
cbde.store %_action, %0 : memref<i32> loc("C:\\Users\\fanny\\OneDrive\\cours\\INFO\\S3\\T3\\Projet T3\\Projet T3\\ucPartie.cs" :378 :38)
br ^0

^0: // BinaryBranchBlock
%1 = cbde.unknown : none loc("C:\\Users\\fanny\\OneDrive\\cours\\INFO\\S3\\T3\\Projet T3\\Projet T3\\ucPartie.cs" :381 :27) // Not a variable of known type: dsLocal
%2 = cbde.unknown : none loc("C:\\Users\\fanny\\OneDrive\\cours\\INFO\\S3\\T3\\Projet T3\\Projet T3\\ucPartie.cs" :381 :27) // dsLocal.Tables (SimpleMemberAccessExpression)
%3 = cbde.unknown : none loc("C:\\Users\\fanny\\OneDrive\\cours\\INFO\\S3\\T3\\Projet T3\\Projet T3\\ucPartie.cs" :381 :42) // "cours" (StringLiteralExpression)
%4 = cbde.unknown : none loc("C:\\Users\\fanny\\OneDrive\\cours\\INFO\\S3\\T3\\Projet T3\\Projet T3\\ucPartie.cs" :381 :27) // dsLocal.Tables["cours"] (ElementAccessExpression)
%5 = cbde.unknown : none loc("C:\\Users\\fanny\\OneDrive\\cours\\INFO\\S3\\T3\\Projet T3\\Projet T3\\ucPartie.cs" :381 :27) // dsLocal.Tables["cours"].Rows (SimpleMemberAccessExpression)
%6 = cbde.unknown : i32 loc("C:\\Users\\fanny\\OneDrive\\cours\\INFO\\S3\\T3\\Projet T3\\Projet T3\\ucPartie.cs" :381 :56) // Not a variable of known type: idProf
%7 = cbde.unknown : none loc("C:\\Users\\fanny\\OneDrive\\cours\\INFO\\S3\\T3\\Projet T3\\Projet T3\\ucPartie.cs" :381 :27) // dsLocal.Tables["cours"].Rows[idProf] (ElementAccessExpression)
%8 = constant 3 : i32 loc("C:\\Users\\fanny\\OneDrive\\cours\\INFO\\S3\\T3\\Projet T3\\Projet T3\\ucPartie.cs" :381 :64)
%9 = cbde.unknown : none loc("C:\\Users\\fanny\\OneDrive\\cours\\INFO\\S3\\T3\\Projet T3\\Projet T3\\ucPartie.cs" :381 :27) // dsLocal.Tables["cours"].Rows[idProf][3] (ElementAccessExpression)
%10 = cbde.unknown : i32 loc("C:\\Users\\fanny\\OneDrive\\cours\\INFO\\S3\\T3\\Projet T3\\Projet T3\\ucPartie.cs" :381 :22) // (int)dsLocal.Tables["cours"].Rows[idProf][3] (CastExpression)
%11 = cbde.alloca i32 loc("C:\\Users\\fanny\\OneDrive\\cours\\INFO\\S3\\T3\\Projet T3\\Projet T3\\ucPartie.cs" :381 :16) // res
cbde.store %10, %11 : memref<i32> loc("C:\\Users\\fanny\\OneDrive\\cours\\INFO\\S3\\T3\\Projet T3\\Projet T3\\ucPartie.cs" :381 :16)
%12 = cbde.load %0 : memref<i32> loc("C:\\Users\\fanny\\OneDrive\\cours\\INFO\\S3\\T3\\Projet T3\\Projet T3\\ucPartie.cs" :382 :16)
%13 = constant 2 : i32 loc("C:\\Users\\fanny\\OneDrive\\cours\\INFO\\S3\\T3\\Projet T3\\Projet T3\\ucPartie.cs" :382 :26)
%14 = cmpi "eq", %12, %13 : i32 loc("C:\\Users\\fanny\\OneDrive\\cours\\INFO\\S3\\T3\\Projet T3\\Projet T3\\ucPartie.cs" :382 :16)
cond_br %14, ^1, ^2 loc("C:\\Users\\fanny\\OneDrive\\cours\\INFO\\S3\\T3\\Projet T3\\Projet T3\\ucPartie.cs" :382 :16)

^1: // SimpleBlock
%15 = cbde.load %11 : memref<i32> loc("C:\\Users\\fanny\\OneDrive\\cours\\INFO\\S3\\T3\\Projet T3\\Projet T3\\ucPartie.cs" :383 :16)
%16 = constant 10 : i32 loc("C:\\Users\\fanny\\OneDrive\\cours\\INFO\\S3\\T3\\Projet T3\\Projet T3\\ucPartie.cs" :383 :23)
%17 = addi %15, %16 : i32 loc("C:\\Users\\fanny\\OneDrive\\cours\\INFO\\S3\\T3\\Projet T3\\Projet T3\\ucPartie.cs" :383 :16)
cbde.store %17, %11 : memref<i32> loc("C:\\Users\\fanny\\OneDrive\\cours\\INFO\\S3\\T3\\Projet T3\\Projet T3\\ucPartie.cs" :383 :16)
br ^2

^2: // BinaryBranchBlock
%18 = cbde.load %0 : memref<i32> loc("C:\\Users\\fanny\\OneDrive\\cours\\INFO\\S3\\T3\\Projet T3\\Projet T3\\ucPartie.cs" :384 :16)
%19 = constant 3 : i32 loc("C:\\Users\\fanny\\OneDrive\\cours\\INFO\\S3\\T3\\Projet T3\\Projet T3\\ucPartie.cs" :384 :26)
%20 = cmpi "eq", %18, %19 : i32 loc("C:\\Users\\fanny\\OneDrive\\cours\\INFO\\S3\\T3\\Projet T3\\Projet T3\\ucPartie.cs" :384 :16)
cond_br %20, ^3, ^4 loc("C:\\Users\\fanny\\OneDrive\\cours\\INFO\\S3\\T3\\Projet T3\\Projet T3\\ucPartie.cs" :384 :16)

^3: // SimpleBlock
%21 = cbde.load %11 : memref<i32> loc("C:\\Users\\fanny\\OneDrive\\cours\\INFO\\S3\\T3\\Projet T3\\Projet T3\\ucPartie.cs" :385 :16)
%22 = constant 10 : i32 loc("C:\\Users\\fanny\\OneDrive\\cours\\INFO\\S3\\T3\\Projet T3\\Projet T3\\ucPartie.cs" :385 :23)
%23 = subi %21, %22 : i32 loc("C:\\Users\\fanny\\OneDrive\\cours\\INFO\\S3\\T3\\Projet T3\\Projet T3\\ucPartie.cs" :385 :16)
cbde.store %23, %11 : memref<i32> loc("C:\\Users\\fanny\\OneDrive\\cours\\INFO\\S3\\T3\\Projet T3\\Projet T3\\ucPartie.cs" :385 :16)
br ^4

^4: // BinaryBranchBlock
%24 = cbde.load %11 : memref<i32> loc("C:\\Users\\fanny\\OneDrive\\cours\\INFO\\S3\\T3\\Projet T3\\Projet T3\\ucPartie.cs" :388 :16)
%25 = constant 0 : i32 loc("C:\\Users\\fanny\\OneDrive\\cours\\INFO\\S3\\T3\\Projet T3\\Projet T3\\ucPartie.cs" :388 :22)
%26 = cmpi "slt", %24, %25 : i32 loc("C:\\Users\\fanny\\OneDrive\\cours\\INFO\\S3\\T3\\Projet T3\\Projet T3\\ucPartie.cs" :388 :16)
cond_br %26, ^5, ^6 loc("C:\\Users\\fanny\\OneDrive\\cours\\INFO\\S3\\T3\\Projet T3\\Projet T3\\ucPartie.cs" :388 :16)

^5: // SimpleBlock
%27 = constant 0 : i32 loc("C:\\Users\\fanny\\OneDrive\\cours\\INFO\\S3\\T3\\Projet T3\\Projet T3\\ucPartie.cs" :389 :22)
cbde.store %27, %11 : memref<i32> loc("C:\\Users\\fanny\\OneDrive\\cours\\INFO\\S3\\T3\\Projet T3\\Projet T3\\ucPartie.cs" :389 :16)
br ^6

^6: // BinaryBranchBlock
%28 = cbde.load %11 : memref<i32> loc("C:\\Users\\fanny\\OneDrive\\cours\\INFO\\S3\\T3\\Projet T3\\Projet T3\\ucPartie.cs" :390 :16)
%29 = constant 100 : i32 loc("C:\\Users\\fanny\\OneDrive\\cours\\INFO\\S3\\T3\\Projet T3\\Projet T3\\ucPartie.cs" :390 :22)
%30 = cmpi "sgt", %28, %29 : i32 loc("C:\\Users\\fanny\\OneDrive\\cours\\INFO\\S3\\T3\\Projet T3\\Projet T3\\ucPartie.cs" :390 :16)
cond_br %30, ^7, ^8 loc("C:\\Users\\fanny\\OneDrive\\cours\\INFO\\S3\\T3\\Projet T3\\Projet T3\\ucPartie.cs" :390 :16)

^7: // SimpleBlock
%31 = constant 100 : i32 loc("C:\\Users\\fanny\\OneDrive\\cours\\INFO\\S3\\T3\\Projet T3\\Projet T3\\ucPartie.cs" :391 :22)
cbde.store %31, %11 : memref<i32> loc("C:\\Users\\fanny\\OneDrive\\cours\\INFO\\S3\\T3\\Projet T3\\Projet T3\\ucPartie.cs" :391 :16)
br ^8

^8: // JumpBlock
%32 = cbde.load %11 : memref<i32> loc("C:\\Users\\fanny\\OneDrive\\cours\\INFO\\S3\\T3\\Projet T3\\Projet T3\\ucPartie.cs" :392 :19)
return %32 : i32 loc("C:\\Users\\fanny\\OneDrive\\cours\\INFO\\S3\\T3\\Projet T3\\Projet T3\\ucPartie.cs" :392 :12)

^9: // ExitBlock
cbde.unreachable

}
// Skipping function enabledBouton(), it contains poisonous unsupported syntaxes

func @_Projet_T3.ucPartie.chargementDsLocal$$() -> () loc("C:\\Users\\fanny\\OneDrive\\cours\\INFO\\S3\\T3\\Projet T3\\Projet T3\\ucPartie.cs" :421 :8) {
^entry :
br ^0

^0: // ForInitializerBlock
%0 = cbde.unknown : none loc("C:\\Users\\fanny\\OneDrive\\cours\\INFO\\S3\\T3\\Projet T3\\Projet T3\\ucPartie.cs" :425 :12) // Not a variable of known type: connex
%1 = cbde.unknown : none loc("C:\\Users\\fanny\\OneDrive\\cours\\INFO\\S3\\T3\\Projet T3\\Projet T3\\ucPartie.cs" :425 :12) // connex.ConnectionString (SimpleMemberAccessExpression)
%2 = cbde.unknown : none loc("C:\\Users\\fanny\\OneDrive\\cours\\INFO\\S3\\T3\\Projet T3\\Projet T3\\ucPartie.cs" :425 :38) // @"Provider = Microsoft.Jet.OLEDB.4.0; Data Source = ..\DBJeu.mdb" (StringLiteralExpression)
%3 = cbde.unknown : none loc("C:\\Users\\fanny\\OneDrive\\cours\\INFO\\S3\\T3\\Projet T3\\Projet T3\\ucPartie.cs" :426 :12) // Not a variable of known type: connex
%4 = cbde.unknown : none loc("C:\\Users\\fanny\\OneDrive\\cours\\INFO\\S3\\T3\\Projet T3\\Projet T3\\ucPartie.cs" :426 :12) // connex.Open() (InvocationExpression)
%5 = cbde.unknown : none loc("C:\\Users\\fanny\\OneDrive\\cours\\INFO\\S3\\T3\\Projet T3\\Projet T3\\ucPartie.cs" :429 :36) // Not a variable of known type: connex
// Entity from another assembly: OleDbSchemaGuid
%6 = cbde.unknown : none loc("C:\\Users\\fanny\\OneDrive\\cours\\INFO\\S3\\T3\\Projet T3\\Projet T3\\ucPartie.cs" :429 :63) // OleDbSchemaGuid.Tables (SimpleMemberAccessExpression)
%7 = cbde.unknown : none loc("C:\\Users\\fanny\\OneDrive\\cours\\INFO\\S3\\T3\\Projet T3\\Projet T3\\ucPartie.cs" :429 :98) //  (OmittedArraySizeExpression)
%8 = cbde.unknown : none loc("C:\\Users\\fanny\\OneDrive\\cours\\INFO\\S3\\T3\\Projet T3\\Projet T3\\ucPartie.cs" :429 :91) // object[] (ArrayType)
%9 = cbde.unknown : none loc("C:\\Users\\fanny\\OneDrive\\cours\\INFO\\S3\\T3\\Projet T3\\Projet T3\\ucPartie.cs" :429 :87) // new object[] { null, null, null, "TABLE" } (ArrayCreationExpression)
%10 = cbde.unknown : none loc("C:\\Users\\fanny\\OneDrive\\cours\\INFO\\S3\\T3\\Projet T3\\Projet T3\\ucPartie.cs" :429 :102) // null (NullLiteralExpression)
%11 = cbde.unknown : none loc("C:\\Users\\fanny\\OneDrive\\cours\\INFO\\S3\\T3\\Projet T3\\Projet T3\\ucPartie.cs" :429 :108) // null (NullLiteralExpression)
%12 = cbde.unknown : none loc("C:\\Users\\fanny\\OneDrive\\cours\\INFO\\S3\\T3\\Projet T3\\Projet T3\\ucPartie.cs" :429 :114) // null (NullLiteralExpression)
%13 = cbde.unknown : none loc("C:\\Users\\fanny\\OneDrive\\cours\\INFO\\S3\\T3\\Projet T3\\Projet T3\\ucPartie.cs" :429 :120) // "TABLE" (StringLiteralExpression)
%14 = cbde.unknown : none loc("C:\\Users\\fanny\\OneDrive\\cours\\INFO\\S3\\T3\\Projet T3\\Projet T3\\ucPartie.cs" :429 :36) // connex.GetOleDbSchemaTable(OleDbSchemaGuid.Tables, new object[] { null, null, null, "TABLE" }) (InvocationExpression)
%16 = cbde.unknown : none loc("C:\\Users\\fanny\\OneDrive\\cours\\INFO\\S3\\T3\\Projet T3\\Projet T3\\ucPartie.cs" :431 :12) // Not a variable of known type: connex
%17 = cbde.unknown : none loc("C:\\Users\\fanny\\OneDrive\\cours\\INFO\\S3\\T3\\Projet T3\\Projet T3\\ucPartie.cs" :431 :12) // connex.Close() (InvocationExpression)
%20 = constant 0 : i32 loc("C:\\Users\\fanny\\OneDrive\\cours\\INFO\\S3\\T3\\Projet T3\\Projet T3\\ucPartie.cs" :436 :25)
%21 = cbde.alloca i32 loc("C:\\Users\\fanny\\OneDrive\\cours\\INFO\\S3\\T3\\Projet T3\\Projet T3\\ucPartie.cs" :436 :21) // i
cbde.store %20, %21 : memref<i32> loc("C:\\Users\\fanny\\OneDrive\\cours\\INFO\\S3\\T3\\Projet T3\\Projet T3\\ucPartie.cs" :436 :21)
br ^1

^1: // BinaryBranchBlock
%22 = cbde.load %21 : memref<i32> loc("C:\\Users\\fanny\\OneDrive\\cours\\INFO\\S3\\T3\\Projet T3\\Projet T3\\ucPartie.cs" :436 :28)
%23 = cbde.unknown : none loc("C:\\Users\\fanny\\OneDrive\\cours\\INFO\\S3\\T3\\Projet T3\\Projet T3\\ucPartie.cs" :436 :32) // Not a variable of known type: schemaTable
%24 = cbde.unknown : none loc("C:\\Users\\fanny\\OneDrive\\cours\\INFO\\S3\\T3\\Projet T3\\Projet T3\\ucPartie.cs" :436 :32) // schemaTable.Rows (SimpleMemberAccessExpression)
%25 = cbde.unknown : i32 loc("C:\\Users\\fanny\\OneDrive\\cours\\INFO\\S3\\T3\\Projet T3\\Projet T3\\ucPartie.cs" :436 :32) // schemaTable.Rows.Count (SimpleMemberAccessExpression)
%26 = cmpi "slt", %22, %25 : i32 loc("C:\\Users\\fanny\\OneDrive\\cours\\INFO\\S3\\T3\\Projet T3\\Projet T3\\ucPartie.cs" :436 :28)
cond_br %26, ^2, ^3 loc("C:\\Users\\fanny\\OneDrive\\cours\\INFO\\S3\\T3\\Projet T3\\Projet T3\\ucPartie.cs" :436 :28)

^2: // BinaryBranchBlock
%27 = cbde.unknown : none loc("C:\\Users\\fanny\\OneDrive\\cours\\INFO\\S3\\T3\\Projet T3\\Projet T3\\ucPartie.cs" :439 :27) // Not a variable of known type: schemaTable
%28 = cbde.unknown : none loc("C:\\Users\\fanny\\OneDrive\\cours\\INFO\\S3\\T3\\Projet T3\\Projet T3\\ucPartie.cs" :439 :27) // schemaTable.Rows (SimpleMemberAccessExpression)
%29 = cbde.load %21 : memref<i32> loc("C:\\Users\\fanny\\OneDrive\\cours\\INFO\\S3\\T3\\Projet T3\\Projet T3\\ucPartie.cs" :439 :44)
%30 = cbde.unknown : none loc("C:\\Users\\fanny\\OneDrive\\cours\\INFO\\S3\\T3\\Projet T3\\Projet T3\\ucPartie.cs" :439 :27) // schemaTable.Rows[i] (ElementAccessExpression)
%31 = constant 2 : i32 loc("C:\\Users\\fanny\\OneDrive\\cours\\INFO\\S3\\T3\\Projet T3\\Projet T3\\ucPartie.cs" :439 :47)
%32 = cbde.unknown : none loc("C:\\Users\\fanny\\OneDrive\\cours\\INFO\\S3\\T3\\Projet T3\\Projet T3\\ucPartie.cs" :439 :27) // schemaTable.Rows[i][2] (ElementAccessExpression)
%33 = cbde.unknown : none loc("C:\\Users\\fanny\\OneDrive\\cours\\INFO\\S3\\T3\\Projet T3\\Projet T3\\ucPartie.cs" :439 :27) // schemaTable.Rows[i][2].ToString() (InvocationExpression)
%34 = cbde.unknown : none loc("C:\\Users\\fanny\\OneDrive\\cours\\INFO\\S3\\T3\\Projet T3\\Projet T3\\ucPartie.cs" :442 :20) // Not a variable of known type: nomTable
%35 = cbde.unknown : none loc("C:\\Users\\fanny\\OneDrive\\cours\\INFO\\S3\\T3\\Projet T3\\Projet T3\\ucPartie.cs" :442 :32) // "scores" (StringLiteralExpression)
%36 = cbde.unknown : i1  loc("C:\\Users\\fanny\\OneDrive\\cours\\INFO\\S3\\T3\\Projet T3\\Projet T3\\ucPartie.cs" :442 :20) // comparison of unknown type: nomTable == "scores"
cond_br %36, ^4, ^5 loc("C:\\Users\\fanny\\OneDrive\\cours\\INFO\\S3\\T3\\Projet T3\\Projet T3\\ucPartie.cs" :442 :20)

^4: // SimpleBlock
%37 = cbde.unknown : none loc("C:\\Users\\fanny\\OneDrive\\cours\\INFO\\S3\\T3\\Projet T3\\Projet T3\\ucPartie.cs" :443 :30) // "select * from [" (StringLiteralExpression)
%38 = cbde.unknown : none loc("C:\\Users\\fanny\\OneDrive\\cours\\INFO\\S3\\T3\\Projet T3\\Projet T3\\ucPartie.cs" :443 :50) // Not a variable of known type: nomTable
%39 = cbde.unknown : none loc("C:\\Users\\fanny\\OneDrive\\cours\\INFO\\S3\\T3\\Projet T3\\Projet T3\\ucPartie.cs" :443 :30) // Binary expression on unsupported types "select * from [" + nomTable
%40 = cbde.unknown : none loc("C:\\Users\\fanny\\OneDrive\\cours\\INFO\\S3\\T3\\Projet T3\\Projet T3\\ucPartie.cs" :443 :61) // "] order by score,pseudo" (StringLiteralExpression)
%41 = cbde.unknown : none loc("C:\\Users\\fanny\\OneDrive\\cours\\INFO\\S3\\T3\\Projet T3\\Projet T3\\ucPartie.cs" :443 :30) // Binary expression on unsupported types "select * from [" + nomTable + "] order by score,pseudo"
br ^6

^5: // BinaryBranchBlock
%42 = cbde.unknown : none loc("C:\\Users\\fanny\\OneDrive\\cours\\INFO\\S3\\T3\\Projet T3\\Projet T3\\ucPartie.cs" :444 :25) // Not a variable of known type: nomTable
%43 = cbde.unknown : none loc("C:\\Users\\fanny\\OneDrive\\cours\\INFO\\S3\\T3\\Projet T3\\Projet T3\\ucPartie.cs" :444 :37) // "cours" (StringLiteralExpression)
%44 = cbde.unknown : i1  loc("C:\\Users\\fanny\\OneDrive\\cours\\INFO\\S3\\T3\\Projet T3\\Projet T3\\ucPartie.cs" :444 :25) // comparison of unknown type: nomTable == "cours"
cond_br %44, ^7, ^8 loc("C:\\Users\\fanny\\OneDrive\\cours\\INFO\\S3\\T3\\Projet T3\\Projet T3\\ucPartie.cs" :444 :25)

^7: // SimpleBlock
%45 = cbde.unknown : none loc("C:\\Users\\fanny\\OneDrive\\cours\\INFO\\S3\\T3\\Projet T3\\Projet T3\\ucPartie.cs" :445 :30) // "select * from [" (StringLiteralExpression)
%46 = cbde.unknown : none loc("C:\\Users\\fanny\\OneDrive\\cours\\INFO\\S3\\T3\\Projet T3\\Projet T3\\ucPartie.cs" :445 :50) // Not a variable of known type: nomTable
%47 = cbde.unknown : none loc("C:\\Users\\fanny\\OneDrive\\cours\\INFO\\S3\\T3\\Projet T3\\Projet T3\\ucPartie.cs" :445 :30) // Binary expression on unsupported types "select * from [" + nomTable
%48 = cbde.unknown : none loc("C:\\Users\\fanny\\OneDrive\\cours\\INFO\\S3\\T3\\Projet T3\\Projet T3\\ucPartie.cs" :445 :61) // "] order by idProf" (StringLiteralExpression)
%49 = cbde.unknown : none loc("C:\\Users\\fanny\\OneDrive\\cours\\INFO\\S3\\T3\\Projet T3\\Projet T3\\ucPartie.cs" :445 :30) // Binary expression on unsupported types "select * from [" + nomTable + "] order by idProf"
br ^6

^8: // SimpleBlock
%50 = cbde.unknown : none loc("C:\\Users\\fanny\\OneDrive\\cours\\INFO\\S3\\T3\\Projet T3\\Projet T3\\ucPartie.cs" :447 :30) // "select * from [" (StringLiteralExpression)
%51 = cbde.unknown : none loc("C:\\Users\\fanny\\OneDrive\\cours\\INFO\\S3\\T3\\Projet T3\\Projet T3\\ucPartie.cs" :447 :50) // Not a variable of known type: nomTable
%52 = cbde.unknown : none loc("C:\\Users\\fanny\\OneDrive\\cours\\INFO\\S3\\T3\\Projet T3\\Projet T3\\ucPartie.cs" :447 :30) // Binary expression on unsupported types "select * from [" + nomTable
%53 = cbde.unknown : none loc("C:\\Users\\fanny\\OneDrive\\cours\\INFO\\S3\\T3\\Projet T3\\Projet T3\\ucPartie.cs" :447 :61) // "]" (StringLiteralExpression)
%54 = cbde.unknown : none loc("C:\\Users\\fanny\\OneDrive\\cours\\INFO\\S3\\T3\\Projet T3\\Projet T3\\ucPartie.cs" :447 :30) // Binary expression on unsupported types "select * from [" + nomTable + "]"
br ^6

^6: // SimpleBlock
%55 = cbde.unknown : none loc("C:\\Users\\fanny\\OneDrive\\cours\\INFO\\S3\\T3\\Projet T3\\Projet T3\\ucPartie.cs" :450 :51) // Not a variable of known type: requete
%56 = cbde.unknown : none loc("C:\\Users\\fanny\\OneDrive\\cours\\INFO\\S3\\T3\\Projet T3\\Projet T3\\ucPartie.cs" :450 :60) // Not a variable of known type: connex
%57 = cbde.unknown : none loc("C:\\Users\\fanny\\OneDrive\\cours\\INFO\\S3\\T3\\Projet T3\\Projet T3\\ucPartie.cs" :450 :34) // new OleDbCommand(requete, connex) (ObjectCreationExpression)
%59 = cbde.unknown : none loc("C:\\Users\\fanny\\OneDrive\\cours\\INFO\\S3\\T3\\Projet T3\\Projet T3\\ucPartie.cs" :451 :59) // Not a variable of known type: cd
%60 = cbde.unknown : none loc("C:\\Users\\fanny\\OneDrive\\cours\\INFO\\S3\\T3\\Projet T3\\Projet T3\\ucPartie.cs" :451 :38) // new OleDbDataAdapter(cd) (ObjectCreationExpression)
%62 = cbde.unknown : none loc("C:\\Users\\fanny\\OneDrive\\cours\\INFO\\S3\\T3\\Projet T3\\Projet T3\\ucPartie.cs" :454 :16) // Not a variable of known type: da
%63 = cbde.unknown : none loc("C:\\Users\\fanny\\OneDrive\\cours\\INFO\\S3\\T3\\Projet T3\\Projet T3\\ucPartie.cs" :454 :24) // Not a variable of known type: dsLocal
%64 = cbde.unknown : none loc("C:\\Users\\fanny\\OneDrive\\cours\\INFO\\S3\\T3\\Projet T3\\Projet T3\\ucPartie.cs" :454 :33) // Not a variable of known type: nomTable
%65 = cbde.unknown : i32 loc("C:\\Users\\fanny\\OneDrive\\cours\\INFO\\S3\\T3\\Projet T3\\Projet T3\\ucPartie.cs" :454 :16) // da.Fill(dsLocal, nomTable) (InvocationExpression)
br ^9

^9: // SimpleBlock
%66 = cbde.load %21 : memref<i32> loc("C:\\Users\\fanny\\OneDrive\\cours\\INFO\\S3\\T3\\Projet T3\\Projet T3\\ucPartie.cs" :436 :56)
%67 = constant 1 : i32 loc("C:\\Users\\fanny\\OneDrive\\cours\\INFO\\S3\\T3\\Projet T3\\Projet T3\\ucPartie.cs" :436 :56)
%68 = addi %66, %67 : i32 loc("C:\\Users\\fanny\\OneDrive\\cours\\INFO\\S3\\T3\\Projet T3\\Projet T3\\ucPartie.cs" :436 :56)
cbde.store %68, %21 : memref<i32> loc("C:\\Users\\fanny\\OneDrive\\cours\\INFO\\S3\\T3\\Projet T3\\Projet T3\\ucPartie.cs" :436 :56)
br ^1

^3: // ExitBlock
return

}
