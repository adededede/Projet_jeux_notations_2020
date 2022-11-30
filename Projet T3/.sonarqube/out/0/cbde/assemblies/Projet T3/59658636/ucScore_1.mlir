// Skipping function remplirScore(), it contains poisonous unsupported syntaxes

func @_Projet_T3.ucScore.chargementDsLocal$$() -> () loc("C:\\Users\\fanny\\OneDrive\\cours\\INFO\\S3\\T3\\Projet T3\\Projet T3\\ucScore.cs" :117 :8) {
^entry :
br ^0

^0: // ForInitializerBlock
%0 = cbde.unknown : none loc("C:\\Users\\fanny\\OneDrive\\cours\\INFO\\S3\\T3\\Projet T3\\Projet T3\\ucScore.cs" :121 :12) // Not a variable of known type: connex
%1 = cbde.unknown : none loc("C:\\Users\\fanny\\OneDrive\\cours\\INFO\\S3\\T3\\Projet T3\\Projet T3\\ucScore.cs" :121 :12) // connex.ConnectionString (SimpleMemberAccessExpression)
%2 = cbde.unknown : none loc("C:\\Users\\fanny\\OneDrive\\cours\\INFO\\S3\\T3\\Projet T3\\Projet T3\\ucScore.cs" :121 :38) // @"Provider = Microsoft.Jet.OLEDB.4.0; Data Source = ..\DBJeu.mdb" (StringLiteralExpression)
%3 = cbde.unknown : none loc("C:\\Users\\fanny\\OneDrive\\cours\\INFO\\S3\\T3\\Projet T3\\Projet T3\\ucScore.cs" :122 :12) // Not a variable of known type: connex
%4 = cbde.unknown : none loc("C:\\Users\\fanny\\OneDrive\\cours\\INFO\\S3\\T3\\Projet T3\\Projet T3\\ucScore.cs" :122 :12) // connex.Open() (InvocationExpression)
%5 = cbde.unknown : none loc("C:\\Users\\fanny\\OneDrive\\cours\\INFO\\S3\\T3\\Projet T3\\Projet T3\\ucScore.cs" :125 :36) // Not a variable of known type: connex
// Entity from another assembly: OleDbSchemaGuid
%6 = cbde.unknown : none loc("C:\\Users\\fanny\\OneDrive\\cours\\INFO\\S3\\T3\\Projet T3\\Projet T3\\ucScore.cs" :125 :63) // OleDbSchemaGuid.Tables (SimpleMemberAccessExpression)
%7 = cbde.unknown : none loc("C:\\Users\\fanny\\OneDrive\\cours\\INFO\\S3\\T3\\Projet T3\\Projet T3\\ucScore.cs" :125 :98) //  (OmittedArraySizeExpression)
%8 = cbde.unknown : none loc("C:\\Users\\fanny\\OneDrive\\cours\\INFO\\S3\\T3\\Projet T3\\Projet T3\\ucScore.cs" :125 :91) // object[] (ArrayType)
%9 = cbde.unknown : none loc("C:\\Users\\fanny\\OneDrive\\cours\\INFO\\S3\\T3\\Projet T3\\Projet T3\\ucScore.cs" :125 :87) // new object[] { null, null, null, "TABLE" } (ArrayCreationExpression)
%10 = cbde.unknown : none loc("C:\\Users\\fanny\\OneDrive\\cours\\INFO\\S3\\T3\\Projet T3\\Projet T3\\ucScore.cs" :125 :102) // null (NullLiteralExpression)
%11 = cbde.unknown : none loc("C:\\Users\\fanny\\OneDrive\\cours\\INFO\\S3\\T3\\Projet T3\\Projet T3\\ucScore.cs" :125 :108) // null (NullLiteralExpression)
%12 = cbde.unknown : none loc("C:\\Users\\fanny\\OneDrive\\cours\\INFO\\S3\\T3\\Projet T3\\Projet T3\\ucScore.cs" :125 :114) // null (NullLiteralExpression)
%13 = cbde.unknown : none loc("C:\\Users\\fanny\\OneDrive\\cours\\INFO\\S3\\T3\\Projet T3\\Projet T3\\ucScore.cs" :125 :120) // "TABLE" (StringLiteralExpression)
%14 = cbde.unknown : none loc("C:\\Users\\fanny\\OneDrive\\cours\\INFO\\S3\\T3\\Projet T3\\Projet T3\\ucScore.cs" :125 :36) // connex.GetOleDbSchemaTable(OleDbSchemaGuid.Tables, new object[] { null, null, null, "TABLE" }) (InvocationExpression)
%16 = cbde.unknown : none loc("C:\\Users\\fanny\\OneDrive\\cours\\INFO\\S3\\T3\\Projet T3\\Projet T3\\ucScore.cs" :127 :12) // Not a variable of known type: connex
%17 = cbde.unknown : none loc("C:\\Users\\fanny\\OneDrive\\cours\\INFO\\S3\\T3\\Projet T3\\Projet T3\\ucScore.cs" :127 :12) // connex.Close() (InvocationExpression)
%20 = constant 0 : i32 loc("C:\\Users\\fanny\\OneDrive\\cours\\INFO\\S3\\T3\\Projet T3\\Projet T3\\ucScore.cs" :132 :25)
%21 = cbde.alloca i32 loc("C:\\Users\\fanny\\OneDrive\\cours\\INFO\\S3\\T3\\Projet T3\\Projet T3\\ucScore.cs" :132 :21) // i
cbde.store %20, %21 : memref<i32> loc("C:\\Users\\fanny\\OneDrive\\cours\\INFO\\S3\\T3\\Projet T3\\Projet T3\\ucScore.cs" :132 :21)
br ^1

^1: // BinaryBranchBlock
%22 = cbde.load %21 : memref<i32> loc("C:\\Users\\fanny\\OneDrive\\cours\\INFO\\S3\\T3\\Projet T3\\Projet T3\\ucScore.cs" :132 :28)
%23 = cbde.unknown : none loc("C:\\Users\\fanny\\OneDrive\\cours\\INFO\\S3\\T3\\Projet T3\\Projet T3\\ucScore.cs" :132 :32) // Not a variable of known type: schemaTable
%24 = cbde.unknown : none loc("C:\\Users\\fanny\\OneDrive\\cours\\INFO\\S3\\T3\\Projet T3\\Projet T3\\ucScore.cs" :132 :32) // schemaTable.Rows (SimpleMemberAccessExpression)
%25 = cbde.unknown : i32 loc("C:\\Users\\fanny\\OneDrive\\cours\\INFO\\S3\\T3\\Projet T3\\Projet T3\\ucScore.cs" :132 :32) // schemaTable.Rows.Count (SimpleMemberAccessExpression)
%26 = cmpi "slt", %22, %25 : i32 loc("C:\\Users\\fanny\\OneDrive\\cours\\INFO\\S3\\T3\\Projet T3\\Projet T3\\ucScore.cs" :132 :28)
cond_br %26, ^2, ^3 loc("C:\\Users\\fanny\\OneDrive\\cours\\INFO\\S3\\T3\\Projet T3\\Projet T3\\ucScore.cs" :132 :28)

^2: // BinaryBranchBlock
%27 = cbde.unknown : none loc("C:\\Users\\fanny\\OneDrive\\cours\\INFO\\S3\\T3\\Projet T3\\Projet T3\\ucScore.cs" :135 :27) // Not a variable of known type: schemaTable
%28 = cbde.unknown : none loc("C:\\Users\\fanny\\OneDrive\\cours\\INFO\\S3\\T3\\Projet T3\\Projet T3\\ucScore.cs" :135 :27) // schemaTable.Rows (SimpleMemberAccessExpression)
%29 = cbde.load %21 : memref<i32> loc("C:\\Users\\fanny\\OneDrive\\cours\\INFO\\S3\\T3\\Projet T3\\Projet T3\\ucScore.cs" :135 :44)
%30 = cbde.unknown : none loc("C:\\Users\\fanny\\OneDrive\\cours\\INFO\\S3\\T3\\Projet T3\\Projet T3\\ucScore.cs" :135 :27) // schemaTable.Rows[i] (ElementAccessExpression)
%31 = constant 2 : i32 loc("C:\\Users\\fanny\\OneDrive\\cours\\INFO\\S3\\T3\\Projet T3\\Projet T3\\ucScore.cs" :135 :47)
%32 = cbde.unknown : none loc("C:\\Users\\fanny\\OneDrive\\cours\\INFO\\S3\\T3\\Projet T3\\Projet T3\\ucScore.cs" :135 :27) // schemaTable.Rows[i][2] (ElementAccessExpression)
%33 = cbde.unknown : none loc("C:\\Users\\fanny\\OneDrive\\cours\\INFO\\S3\\T3\\Projet T3\\Projet T3\\ucScore.cs" :135 :27) // schemaTable.Rows[i][2].ToString() (InvocationExpression)
%34 = cbde.unknown : none loc("C:\\Users\\fanny\\OneDrive\\cours\\INFO\\S3\\T3\\Projet T3\\Projet T3\\ucScore.cs" :138 :20) // Not a variable of known type: nomTable
%35 = cbde.unknown : none loc("C:\\Users\\fanny\\OneDrive\\cours\\INFO\\S3\\T3\\Projet T3\\Projet T3\\ucScore.cs" :138 :32) // "scores" (StringLiteralExpression)
%36 = cbde.unknown : i1  loc("C:\\Users\\fanny\\OneDrive\\cours\\INFO\\S3\\T3\\Projet T3\\Projet T3\\ucScore.cs" :138 :20) // comparison of unknown type: nomTable == "scores"
cond_br %36, ^4, ^5 loc("C:\\Users\\fanny\\OneDrive\\cours\\INFO\\S3\\T3\\Projet T3\\Projet T3\\ucScore.cs" :138 :20)

^4: // SimpleBlock
%37 = cbde.unknown : none loc("C:\\Users\\fanny\\OneDrive\\cours\\INFO\\S3\\T3\\Projet T3\\Projet T3\\ucScore.cs" :140 :30) // "select * from [" (StringLiteralExpression)
%38 = cbde.unknown : none loc("C:\\Users\\fanny\\OneDrive\\cours\\INFO\\S3\\T3\\Projet T3\\Projet T3\\ucScore.cs" :140 :50) // Not a variable of known type: nomTable
%39 = cbde.unknown : none loc("C:\\Users\\fanny\\OneDrive\\cours\\INFO\\S3\\T3\\Projet T3\\Projet T3\\ucScore.cs" :140 :30) // Binary expression on unsupported types "select * from [" + nomTable
%40 = cbde.unknown : none loc("C:\\Users\\fanny\\OneDrive\\cours\\INFO\\S3\\T3\\Projet T3\\Projet T3\\ucScore.cs" :140 :61) // "] order by difficulte DESC,score DESC" (StringLiteralExpression)
%41 = cbde.unknown : none loc("C:\\Users\\fanny\\OneDrive\\cours\\INFO\\S3\\T3\\Projet T3\\Projet T3\\ucScore.cs" :140 :30) // Binary expression on unsupported types "select * from [" + nomTable + "] order by difficulte DESC,score DESC"
br ^6

^5: // BinaryBranchBlock
%42 = cbde.unknown : none loc("C:\\Users\\fanny\\OneDrive\\cours\\INFO\\S3\\T3\\Projet T3\\Projet T3\\ucScore.cs" :142 :25) // Not a variable of known type: nomTable
%43 = cbde.unknown : none loc("C:\\Users\\fanny\\OneDrive\\cours\\INFO\\S3\\T3\\Projet T3\\Projet T3\\ucScore.cs" :142 :37) // "cours" (StringLiteralExpression)
%44 = cbde.unknown : i1  loc("C:\\Users\\fanny\\OneDrive\\cours\\INFO\\S3\\T3\\Projet T3\\Projet T3\\ucScore.cs" :142 :25) // comparison of unknown type: nomTable == "cours"
cond_br %44, ^7, ^8 loc("C:\\Users\\fanny\\OneDrive\\cours\\INFO\\S3\\T3\\Projet T3\\Projet T3\\ucScore.cs" :142 :25)

^7: // SimpleBlock
%45 = cbde.unknown : none loc("C:\\Users\\fanny\\OneDrive\\cours\\INFO\\S3\\T3\\Projet T3\\Projet T3\\ucScore.cs" :143 :30) // "select * from [" (StringLiteralExpression)
%46 = cbde.unknown : none loc("C:\\Users\\fanny\\OneDrive\\cours\\INFO\\S3\\T3\\Projet T3\\Projet T3\\ucScore.cs" :143 :50) // Not a variable of known type: nomTable
%47 = cbde.unknown : none loc("C:\\Users\\fanny\\OneDrive\\cours\\INFO\\S3\\T3\\Projet T3\\Projet T3\\ucScore.cs" :143 :30) // Binary expression on unsupported types "select * from [" + nomTable
%48 = cbde.unknown : none loc("C:\\Users\\fanny\\OneDrive\\cours\\INFO\\S3\\T3\\Projet T3\\Projet T3\\ucScore.cs" :143 :61) // "] order by idProf" (StringLiteralExpression)
%49 = cbde.unknown : none loc("C:\\Users\\fanny\\OneDrive\\cours\\INFO\\S3\\T3\\Projet T3\\Projet T3\\ucScore.cs" :143 :30) // Binary expression on unsupported types "select * from [" + nomTable + "] order by idProf"
br ^6

^8: // SimpleBlock
%50 = cbde.unknown : none loc("C:\\Users\\fanny\\OneDrive\\cours\\INFO\\S3\\T3\\Projet T3\\Projet T3\\ucScore.cs" :145 :30) // "select * from [" (StringLiteralExpression)
%51 = cbde.unknown : none loc("C:\\Users\\fanny\\OneDrive\\cours\\INFO\\S3\\T3\\Projet T3\\Projet T3\\ucScore.cs" :145 :50) // Not a variable of known type: nomTable
%52 = cbde.unknown : none loc("C:\\Users\\fanny\\OneDrive\\cours\\INFO\\S3\\T3\\Projet T3\\Projet T3\\ucScore.cs" :145 :30) // Binary expression on unsupported types "select * from [" + nomTable
%53 = cbde.unknown : none loc("C:\\Users\\fanny\\OneDrive\\cours\\INFO\\S3\\T3\\Projet T3\\Projet T3\\ucScore.cs" :145 :61) // "]" (StringLiteralExpression)
%54 = cbde.unknown : none loc("C:\\Users\\fanny\\OneDrive\\cours\\INFO\\S3\\T3\\Projet T3\\Projet T3\\ucScore.cs" :145 :30) // Binary expression on unsupported types "select * from [" + nomTable + "]"
br ^6

^6: // SimpleBlock
%55 = cbde.unknown : none loc("C:\\Users\\fanny\\OneDrive\\cours\\INFO\\S3\\T3\\Projet T3\\Projet T3\\ucScore.cs" :148 :51) // Not a variable of known type: requete
%56 = cbde.unknown : none loc("C:\\Users\\fanny\\OneDrive\\cours\\INFO\\S3\\T3\\Projet T3\\Projet T3\\ucScore.cs" :148 :60) // Not a variable of known type: connex
%57 = cbde.unknown : none loc("C:\\Users\\fanny\\OneDrive\\cours\\INFO\\S3\\T3\\Projet T3\\Projet T3\\ucScore.cs" :148 :34) // new OleDbCommand(requete, connex) (ObjectCreationExpression)
%59 = cbde.unknown : none loc("C:\\Users\\fanny\\OneDrive\\cours\\INFO\\S3\\T3\\Projet T3\\Projet T3\\ucScore.cs" :149 :59) // Not a variable of known type: cd
%60 = cbde.unknown : none loc("C:\\Users\\fanny\\OneDrive\\cours\\INFO\\S3\\T3\\Projet T3\\Projet T3\\ucScore.cs" :149 :38) // new OleDbDataAdapter(cd) (ObjectCreationExpression)
%62 = cbde.unknown : none loc("C:\\Users\\fanny\\OneDrive\\cours\\INFO\\S3\\T3\\Projet T3\\Projet T3\\ucScore.cs" :152 :16) // Not a variable of known type: da
%63 = cbde.unknown : none loc("C:\\Users\\fanny\\OneDrive\\cours\\INFO\\S3\\T3\\Projet T3\\Projet T3\\ucScore.cs" :152 :24) // Not a variable of known type: dsLocal
%64 = cbde.unknown : none loc("C:\\Users\\fanny\\OneDrive\\cours\\INFO\\S3\\T3\\Projet T3\\Projet T3\\ucScore.cs" :152 :33) // Not a variable of known type: nomTable
%65 = cbde.unknown : i32 loc("C:\\Users\\fanny\\OneDrive\\cours\\INFO\\S3\\T3\\Projet T3\\Projet T3\\ucScore.cs" :152 :16) // da.Fill(dsLocal, nomTable) (InvocationExpression)
br ^9

^9: // SimpleBlock
%66 = cbde.load %21 : memref<i32> loc("C:\\Users\\fanny\\OneDrive\\cours\\INFO\\S3\\T3\\Projet T3\\Projet T3\\ucScore.cs" :132 :56)
%67 = constant 1 : i32 loc("C:\\Users\\fanny\\OneDrive\\cours\\INFO\\S3\\T3\\Projet T3\\Projet T3\\ucScore.cs" :132 :56)
%68 = addi %66, %67 : i32 loc("C:\\Users\\fanny\\OneDrive\\cours\\INFO\\S3\\T3\\Projet T3\\Projet T3\\ucScore.cs" :132 :56)
cbde.store %68, %21 : memref<i32> loc("C:\\Users\\fanny\\OneDrive\\cours\\INFO\\S3\\T3\\Projet T3\\Projet T3\\ucScore.cs" :132 :56)
br ^1

^3: // ExitBlock
return

}
func @_Projet_T3.ucScore.Btn_menu_Click$object.System.EventArgs$(none, none) -> () loc("C:\\Users\\fanny\\OneDrive\\cours\\INFO\\S3\\T3\\Projet T3\\Projet T3\\ucScore.cs" :162 :8) {
^entry (%_sender : none, %_e : none):
%0 = cbde.alloca none loc("C:\\Users\\fanny\\OneDrive\\cours\\INFO\\S3\\T3\\Projet T3\\Projet T3\\ucScore.cs" :162 :36)
cbde.store %_sender, %0 : memref<none> loc("C:\\Users\\fanny\\OneDrive\\cours\\INFO\\S3\\T3\\Projet T3\\Projet T3\\ucScore.cs" :162 :36)
%1 = cbde.alloca none loc("C:\\Users\\fanny\\OneDrive\\cours\\INFO\\S3\\T3\\Projet T3\\Projet T3\\ucScore.cs" :162 :51)
cbde.store %_e, %1 : memref<none> loc("C:\\Users\\fanny\\OneDrive\\cours\\INFO\\S3\\T3\\Projet T3\\Projet T3\\ucScore.cs" :162 :51)
br ^0

^0: // SimpleBlock
%2 = cbde.unknown : none loc("C:\\Users\\fanny\\OneDrive\\cours\\INFO\\S3\\T3\\Projet T3\\Projet T3\\ucScore.cs" :164 :12) // this (ThisExpression)
%3 = cbde.unknown : none loc("C:\\Users\\fanny\\OneDrive\\cours\\INFO\\S3\\T3\\Projet T3\\Projet T3\\ucScore.cs" :164 :12) // this.Controls (SimpleMemberAccessExpression)
%4 = cbde.unknown : none loc("C:\\Users\\fanny\\OneDrive\\cours\\INFO\\S3\\T3\\Projet T3\\Projet T3\\ucScore.cs" :164 :12) // this.Controls.Clear() (InvocationExpression)
%5 = cbde.unknown : none loc("C:\\Users\\fanny\\OneDrive\\cours\\INFO\\S3\\T3\\Projet T3\\Projet T3\\ucScore.cs" :165 :24) // new Menu() (ObjectCreationExpression)
%7 = cbde.unknown : none loc("C:\\Users\\fanny\\OneDrive\\cours\\INFO\\S3\\T3\\Projet T3\\Projet T3\\ucScore.cs" :166 :12) // this (ThisExpression)
%8 = cbde.unknown : none loc("C:\\Users\\fanny\\OneDrive\\cours\\INFO\\S3\\T3\\Projet T3\\Projet T3\\ucScore.cs" :166 :12) // this.Controls (SimpleMemberAccessExpression)
%9 = cbde.unknown : none loc("C:\\Users\\fanny\\OneDrive\\cours\\INFO\\S3\\T3\\Projet T3\\Projet T3\\ucScore.cs" :166 :30) // Not a variable of known type: menu
%10 = cbde.unknown : none loc("C:\\Users\\fanny\\OneDrive\\cours\\INFO\\S3\\T3\\Projet T3\\Projet T3\\ucScore.cs" :166 :12) // this.Controls.Add(menu) (InvocationExpression)
br ^1

^1: // ExitBlock
return

}
func @_Projet_T3.ucScore.Btn_continue_Click$object.System.EventArgs$(none, none) -> () loc("C:\\Users\\fanny\\OneDrive\\cours\\INFO\\S3\\T3\\Projet T3\\Projet T3\\ucScore.cs" :173 :8) {
^entry (%_sender : none, %_e : none):
%0 = cbde.alloca none loc("C:\\Users\\fanny\\OneDrive\\cours\\INFO\\S3\\T3\\Projet T3\\Projet T3\\ucScore.cs" :173 :40)
cbde.store %_sender, %0 : memref<none> loc("C:\\Users\\fanny\\OneDrive\\cours\\INFO\\S3\\T3\\Projet T3\\Projet T3\\ucScore.cs" :173 :40)
%1 = cbde.alloca none loc("C:\\Users\\fanny\\OneDrive\\cours\\INFO\\S3\\T3\\Projet T3\\Projet T3\\ucScore.cs" :173 :55)
cbde.store %_e, %1 : memref<none> loc("C:\\Users\\fanny\\OneDrive\\cours\\INFO\\S3\\T3\\Projet T3\\Projet T3\\ucScore.cs" :173 :55)
br ^0

^0: // SimpleBlock
%2 = cbde.unknown : none loc("C:\\Users\\fanny\\OneDrive\\cours\\INFO\\S3\\T3\\Projet T3\\Projet T3\\ucScore.cs" :175 :12) // this (ThisExpression)
%3 = cbde.unknown : none loc("C:\\Users\\fanny\\OneDrive\\cours\\INFO\\S3\\T3\\Projet T3\\Projet T3\\ucScore.cs" :175 :12) // this.Controls (SimpleMemberAccessExpression)
%4 = cbde.unknown : none loc("C:\\Users\\fanny\\OneDrive\\cours\\INFO\\S3\\T3\\Projet T3\\Projet T3\\ucScore.cs" :175 :12) // this.Controls.Clear() (InvocationExpression)
%5 = cbde.unknown : i32 loc("C:\\Users\\fanny\\OneDrive\\cours\\INFO\\S3\\T3\\Projet T3\\Projet T3\\ucScore.cs" :176 :43) // Not a variable of known type: difficulte
%6 = cbde.unknown : none loc("C:\\Users\\fanny\\OneDrive\\cours\\INFO\\S3\\T3\\Projet T3\\Projet T3\\ucScore.cs" :176 :55) // Not a variable of known type: pseudo
%7 = constant 1 : i32 loc("C:\\Users\\fanny\\OneDrive\\cours\\INFO\\S3\\T3\\Projet T3\\Projet T3\\ucScore.cs" :176 :63)
%8 = cbde.unknown : i32 loc("C:\\Users\\fanny\\OneDrive\\cours\\INFO\\S3\\T3\\Projet T3\\Projet T3\\ucScore.cs" :176 :66) // Not a variable of known type: numJour
%9 = constant 1 : i32 loc("C:\\Users\\fanny\\OneDrive\\cours\\INFO\\S3\\T3\\Projet T3\\Projet T3\\ucScore.cs" :176 :76)
%10 = addi %8, %9 : i32 loc("C:\\Users\\fanny\\OneDrive\\cours\\INFO\\S3\\T3\\Projet T3\\Projet T3\\ucScore.cs" :176 :66)
%11 = constant 100 : i32 loc("C:\\Users\\fanny\\OneDrive\\cours\\INFO\\S3\\T3\\Projet T3\\Projet T3\\ucScore.cs" :176 :79)
%12 = cbde.unknown : none loc("C:\\Users\\fanny\\OneDrive\\cours\\INFO\\S3\\T3\\Projet T3\\Projet T3\\ucScore.cs" :176 :30) // new ucPartie(difficulte, pseudo, 1, numJour + 1, 100) (ObjectCreationExpression)
%14 = cbde.unknown : none loc("C:\\Users\\fanny\\OneDrive\\cours\\INFO\\S3\\T3\\Projet T3\\Projet T3\\ucScore.cs" :177 :12) // this (ThisExpression)
%15 = cbde.unknown : none loc("C:\\Users\\fanny\\OneDrive\\cours\\INFO\\S3\\T3\\Projet T3\\Projet T3\\ucScore.cs" :177 :12) // this.Controls (SimpleMemberAccessExpression)
%16 = cbde.unknown : none loc("C:\\Users\\fanny\\OneDrive\\cours\\INFO\\S3\\T3\\Projet T3\\Projet T3\\ucScore.cs" :177 :30) // Not a variable of known type: partie
%17 = cbde.unknown : none loc("C:\\Users\\fanny\\OneDrive\\cours\\INFO\\S3\\T3\\Projet T3\\Projet T3\\ucScore.cs" :177 :12) // this.Controls.Add(partie) (InvocationExpression)
br ^1

^1: // ExitBlock
return

}
func @_Projet_T3.ucScore.Btn_quitter_Click$object.System.EventArgs$(none, none) -> () loc("C:\\Users\\fanny\\OneDrive\\cours\\INFO\\S3\\T3\\Projet T3\\Projet T3\\ucScore.cs" :184 :8) {
^entry (%_sender : none, %_e : none):
%0 = cbde.alloca none loc("C:\\Users\\fanny\\OneDrive\\cours\\INFO\\S3\\T3\\Projet T3\\Projet T3\\ucScore.cs" :184 :39)
cbde.store %_sender, %0 : memref<none> loc("C:\\Users\\fanny\\OneDrive\\cours\\INFO\\S3\\T3\\Projet T3\\Projet T3\\ucScore.cs" :184 :39)
%1 = cbde.alloca none loc("C:\\Users\\fanny\\OneDrive\\cours\\INFO\\S3\\T3\\Projet T3\\Projet T3\\ucScore.cs" :184 :54)
cbde.store %_e, %1 : memref<none> loc("C:\\Users\\fanny\\OneDrive\\cours\\INFO\\S3\\T3\\Projet T3\\Projet T3\\ucScore.cs" :184 :54)
br ^0

^0: // SimpleBlock
// Entity from another assembly: Application
%2 = cbde.unknown : none loc("C:\\Users\\fanny\\OneDrive\\cours\\INFO\\S3\\T3\\Projet T3\\Projet T3\\ucScore.cs" :186 :12) // Application.Exit() (InvocationExpression)
br ^1

^1: // ExitBlock
return

}
