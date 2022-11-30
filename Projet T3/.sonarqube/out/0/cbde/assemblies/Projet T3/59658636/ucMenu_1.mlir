func @_Projet_T3.Menu.btn_tuto_Click$object.System.EventArgs$(none, none) -> () loc("C:\\Users\\fanny\\OneDrive\\cours\\INFO\\S3\\T3\\Projet T3\\Projet T3\\ucMenu.cs" :41 :8) {
^entry (%_sender : none, %_e : none):
%0 = cbde.alloca none loc("C:\\Users\\fanny\\OneDrive\\cours\\INFO\\S3\\T3\\Projet T3\\Projet T3\\ucMenu.cs" :41 :36)
cbde.store %_sender, %0 : memref<none> loc("C:\\Users\\fanny\\OneDrive\\cours\\INFO\\S3\\T3\\Projet T3\\Projet T3\\ucMenu.cs" :41 :36)
%1 = cbde.alloca none loc("C:\\Users\\fanny\\OneDrive\\cours\\INFO\\S3\\T3\\Projet T3\\Projet T3\\ucMenu.cs" :41 :51)
cbde.store %_e, %1 : memref<none> loc("C:\\Users\\fanny\\OneDrive\\cours\\INFO\\S3\\T3\\Projet T3\\Projet T3\\ucMenu.cs" :41 :51)
br ^0

^0: // SimpleBlock
%2 = cbde.unknown : none loc("C:\\Users\\fanny\\OneDrive\\cours\\INFO\\S3\\T3\\Projet T3\\Projet T3\\ucMenu.cs" :44 :27) // new frmTuto() (ObjectCreationExpression)
%4 = cbde.unknown : none loc("C:\\Users\\fanny\\OneDrive\\cours\\INFO\\S3\\T3\\Projet T3\\Projet T3\\ucMenu.cs" :45 :12) // Not a variable of known type: tuto
%5 = cbde.unknown : none loc("C:\\Users\\fanny\\OneDrive\\cours\\INFO\\S3\\T3\\Projet T3\\Projet T3\\ucMenu.cs" :45 :12) // tuto.ShowDialog() (InvocationExpression)
br ^1

^1: // ExitBlock
return

}
func @_Projet_T3.Menu.btn_quitter_Click$object.System.EventArgs$(none, none) -> () loc("C:\\Users\\fanny\\OneDrive\\cours\\INFO\\S3\\T3\\Projet T3\\Projet T3\\ucMenu.cs" :52 :8) {
^entry (%_sender : none, %_e : none):
%0 = cbde.alloca none loc("C:\\Users\\fanny\\OneDrive\\cours\\INFO\\S3\\T3\\Projet T3\\Projet T3\\ucMenu.cs" :52 :39)
cbde.store %_sender, %0 : memref<none> loc("C:\\Users\\fanny\\OneDrive\\cours\\INFO\\S3\\T3\\Projet T3\\Projet T3\\ucMenu.cs" :52 :39)
%1 = cbde.alloca none loc("C:\\Users\\fanny\\OneDrive\\cours\\INFO\\S3\\T3\\Projet T3\\Projet T3\\ucMenu.cs" :52 :54)
cbde.store %_e, %1 : memref<none> loc("C:\\Users\\fanny\\OneDrive\\cours\\INFO\\S3\\T3\\Projet T3\\Projet T3\\ucMenu.cs" :52 :54)
br ^0

^0: // SimpleBlock
// Entity from another assembly: Application
%2 = cbde.unknown : none loc("C:\\Users\\fanny\\OneDrive\\cours\\INFO\\S3\\T3\\Projet T3\\Projet T3\\ucMenu.cs" :54 :12) // Application.Exit() (InvocationExpression)
br ^1

^1: // ExitBlock
return

}
// Skipping function pnl_facile_Click(none, none), it contains poisonous unsupported syntaxes

func @_Projet_T3.Menu.tbx_pseudo_KeyPress$object.System.Windows.Forms.KeyPressEventArgs$(none, none) -> () loc("C:\\Users\\fanny\\OneDrive\\cours\\INFO\\S3\\T3\\Projet T3\\Projet T3\\ucMenu.cs" :93 :8) {
^entry (%_sender : none, %_e : none):
%0 = cbde.alloca none loc("C:\\Users\\fanny\\OneDrive\\cours\\INFO\\S3\\T3\\Projet T3\\Projet T3\\ucMenu.cs" :93 :41)
cbde.store %_sender, %0 : memref<none> loc("C:\\Users\\fanny\\OneDrive\\cours\\INFO\\S3\\T3\\Projet T3\\Projet T3\\ucMenu.cs" :93 :41)
%1 = cbde.alloca none loc("C:\\Users\\fanny\\OneDrive\\cours\\INFO\\S3\\T3\\Projet T3\\Projet T3\\ucMenu.cs" :93 :56)
cbde.store %_e, %1 : memref<none> loc("C:\\Users\\fanny\\OneDrive\\cours\\INFO\\S3\\T3\\Projet T3\\Projet T3\\ucMenu.cs" :93 :56)
br ^0

^0: // BinaryBranchBlock
%2 = cbde.unknown : none loc("C:\\Users\\fanny\\OneDrive\\cours\\INFO\\S3\\T3\\Projet T3\\Projet T3\\ucMenu.cs" :95 :15) // Not a variable of known type: e
%3 = cbde.unknown : none loc("C:\\Users\\fanny\\OneDrive\\cours\\INFO\\S3\\T3\\Projet T3\\Projet T3\\ucMenu.cs" :95 :15) // e.KeyChar (SimpleMemberAccessExpression)
// Entity from another assembly: Keys
%4 = cbde.unknown : none loc("C:\\Users\\fanny\\OneDrive\\cours\\INFO\\S3\\T3\\Projet T3\\Projet T3\\ucMenu.cs" :95 :34) // Keys.Space (SimpleMemberAccessExpression)
%5 = cbde.unknown : none loc("C:\\Users\\fanny\\OneDrive\\cours\\INFO\\S3\\T3\\Projet T3\\Projet T3\\ucMenu.cs" :95 :28) // (char)Keys.Space (CastExpression)
%6 = cbde.unknown : i1  loc("C:\\Users\\fanny\\OneDrive\\cours\\INFO\\S3\\T3\\Projet T3\\Projet T3\\ucMenu.cs" :95 :15) // comparison of unknown type: e.KeyChar == (char)Keys.Space
cond_br %6, ^1, ^2 loc("C:\\Users\\fanny\\OneDrive\\cours\\INFO\\S3\\T3\\Projet T3\\Projet T3\\ucMenu.cs" :95 :15)

^1: // SimpleBlock
%7 = cbde.unknown : none loc("C:\\Users\\fanny\\OneDrive\\cours\\INFO\\S3\\T3\\Projet T3\\Projet T3\\ucMenu.cs" :97 :16) // Not a variable of known type: e
%8 = cbde.unknown : i1 loc("C:\\Users\\fanny\\OneDrive\\cours\\INFO\\S3\\T3\\Projet T3\\Projet T3\\ucMenu.cs" :97 :16) // e.Handled (SimpleMemberAccessExpression)
%9 = constant 1 : i1 loc("C:\\Users\\fanny\\OneDrive\\cours\\INFO\\S3\\T3\\Projet T3\\Projet T3\\ucMenu.cs" :97 :28) // true
br ^2

^2: // ExitBlock
return

}
func @_Projet_T3.Menu.Tbx_pseudo_Click$object.System.EventArgs$(none, none) -> () loc("C:\\Users\\fanny\\OneDrive\\cours\\INFO\\S3\\T3\\Projet T3\\Projet T3\\ucMenu.cs" :105 :8) {
^entry (%_sender : none, %_e : none):
%0 = cbde.alloca none loc("C:\\Users\\fanny\\OneDrive\\cours\\INFO\\S3\\T3\\Projet T3\\Projet T3\\ucMenu.cs" :105 :38)
cbde.store %_sender, %0 : memref<none> loc("C:\\Users\\fanny\\OneDrive\\cours\\INFO\\S3\\T3\\Projet T3\\Projet T3\\ucMenu.cs" :105 :38)
%1 = cbde.alloca none loc("C:\\Users\\fanny\\OneDrive\\cours\\INFO\\S3\\T3\\Projet T3\\Projet T3\\ucMenu.cs" :105 :53)
cbde.store %_e, %1 : memref<none> loc("C:\\Users\\fanny\\OneDrive\\cours\\INFO\\S3\\T3\\Projet T3\\Projet T3\\ucMenu.cs" :105 :53)
br ^0

^0: // SimpleBlock
%2 = cbde.unknown : none loc("C:\\Users\\fanny\\OneDrive\\cours\\INFO\\S3\\T3\\Projet T3\\Projet T3\\ucMenu.cs" :107 :12) // Not a variable of known type: tbx_pseudo
%3 = cbde.unknown : none loc("C:\\Users\\fanny\\OneDrive\\cours\\INFO\\S3\\T3\\Projet T3\\Projet T3\\ucMenu.cs" :107 :12) // tbx_pseudo.Text (SimpleMemberAccessExpression)
%4 = cbde.unknown : none loc("C:\\Users\\fanny\\OneDrive\\cours\\INFO\\S3\\T3\\Projet T3\\Projet T3\\ucMenu.cs" :107 :30) // "" (StringLiteralExpression)
br ^1

^1: // ExitBlock
return

}
