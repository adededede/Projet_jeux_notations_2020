func @_Projet_T3.ucEtape.btnPrec_Click$object.System.EventArgs$(none, none) -> () loc("C:\\Users\\fanny\\OneDrive\\cours\\INFO\\S3\\T3\\Projet T3\\Projet T3\\ucEtape.cs" :69 :8) {
^entry (%_sender : none, %_e : none):
%0 = cbde.alloca none loc("C:\\Users\\fanny\\OneDrive\\cours\\INFO\\S3\\T3\\Projet T3\\Projet T3\\ucEtape.cs" :69 :35)
cbde.store %_sender, %0 : memref<none> loc("C:\\Users\\fanny\\OneDrive\\cours\\INFO\\S3\\T3\\Projet T3\\Projet T3\\ucEtape.cs" :69 :35)
%1 = cbde.alloca none loc("C:\\Users\\fanny\\OneDrive\\cours\\INFO\\S3\\T3\\Projet T3\\Projet T3\\ucEtape.cs" :69 :50)
cbde.store %_e, %1 : memref<none> loc("C:\\Users\\fanny\\OneDrive\\cours\\INFO\\S3\\T3\\Projet T3\\Projet T3\\ucEtape.cs" :69 :50)
br ^0

^0: // SimpleBlock
%2 = cbde.unknown : i32 loc("C:\\Users\\fanny\\OneDrive\\cours\\INFO\\S3\\T3\\Projet T3\\Projet T3\\ucEtape.cs" :71 :48) // Not a variable of known type: numEtape
%3 = constant 1 : i32 loc("C:\\Users\\fanny\\OneDrive\\cours\\INFO\\S3\\T3\\Projet T3\\Projet T3\\ucEtape.cs" :71 :57)
%4 = subi %2, %3 : i32 loc("C:\\Users\\fanny\\OneDrive\\cours\\INFO\\S3\\T3\\Projet T3\\Projet T3\\ucEtape.cs" :71 :48)
%5 = cbde.unknown : none loc("C:\\Users\\fanny\\OneDrive\\cours\\INFO\\S3\\T3\\Projet T3\\Projet T3\\ucEtape.cs" :71 :36) // new ucEtape(numEtape-1) (ObjectCreationExpression)
%7 = cbde.unknown : none loc("C:\\Users\\fanny\\OneDrive\\cours\\INFO\\S3\\T3\\Projet T3\\Projet T3\\ucEtape.cs" :72 :16) // this (ThisExpression)
%8 = cbde.unknown : none loc("C:\\Users\\fanny\\OneDrive\\cours\\INFO\\S3\\T3\\Projet T3\\Projet T3\\ucEtape.cs" :72 :16) // this.Controls (SimpleMemberAccessExpression)
%9 = cbde.unknown : none loc("C:\\Users\\fanny\\OneDrive\\cours\\INFO\\S3\\T3\\Projet T3\\Projet T3\\ucEtape.cs" :72 :16) // this.Controls.Clear() (InvocationExpression)
%10 = cbde.unknown : none loc("C:\\Users\\fanny\\OneDrive\\cours\\INFO\\S3\\T3\\Projet T3\\Projet T3\\ucEtape.cs" :73 :16) // this (ThisExpression)
%11 = cbde.unknown : none loc("C:\\Users\\fanny\\OneDrive\\cours\\INFO\\S3\\T3\\Projet T3\\Projet T3\\ucEtape.cs" :73 :16) // this.Controls (SimpleMemberAccessExpression)
%12 = cbde.unknown : none loc("C:\\Users\\fanny\\OneDrive\\cours\\INFO\\S3\\T3\\Projet T3\\Projet T3\\ucEtape.cs" :73 :34) // Not a variable of known type: etapeSuiv
%13 = cbde.unknown : none loc("C:\\Users\\fanny\\OneDrive\\cours\\INFO\\S3\\T3\\Projet T3\\Projet T3\\ucEtape.cs" :73 :16) // this.Controls.Add(etapeSuiv) (InvocationExpression)
br ^1

^1: // ExitBlock
return

}
func @_Projet_T3.ucEtape.btnSuivant_Click$object.System.EventArgs$(none, none) -> () loc("C:\\Users\\fanny\\OneDrive\\cours\\INFO\\S3\\T3\\Projet T3\\Projet T3\\ucEtape.cs" :80 :8) {
^entry (%_sender : none, %_e : none):
%0 = cbde.alloca none loc("C:\\Users\\fanny\\OneDrive\\cours\\INFO\\S3\\T3\\Projet T3\\Projet T3\\ucEtape.cs" :80 :38)
cbde.store %_sender, %0 : memref<none> loc("C:\\Users\\fanny\\OneDrive\\cours\\INFO\\S3\\T3\\Projet T3\\Projet T3\\ucEtape.cs" :80 :38)
%1 = cbde.alloca none loc("C:\\Users\\fanny\\OneDrive\\cours\\INFO\\S3\\T3\\Projet T3\\Projet T3\\ucEtape.cs" :80 :53)
cbde.store %_e, %1 : memref<none> loc("C:\\Users\\fanny\\OneDrive\\cours\\INFO\\S3\\T3\\Projet T3\\Projet T3\\ucEtape.cs" :80 :53)
br ^0

^0: // SimpleBlock
%2 = cbde.unknown : i32 loc("C:\\Users\\fanny\\OneDrive\\cours\\INFO\\S3\\T3\\Projet T3\\Projet T3\\ucEtape.cs" :82 :48) // Not a variable of known type: numEtape
%3 = constant 1 : i32 loc("C:\\Users\\fanny\\OneDrive\\cours\\INFO\\S3\\T3\\Projet T3\\Projet T3\\ucEtape.cs" :82 :58)
%4 = addi %2, %3 : i32 loc("C:\\Users\\fanny\\OneDrive\\cours\\INFO\\S3\\T3\\Projet T3\\Projet T3\\ucEtape.cs" :82 :48)
%5 = cbde.unknown : none loc("C:\\Users\\fanny\\OneDrive\\cours\\INFO\\S3\\T3\\Projet T3\\Projet T3\\ucEtape.cs" :82 :36) // new ucEtape(numEtape +1) (ObjectCreationExpression)
%7 = cbde.unknown : none loc("C:\\Users\\fanny\\OneDrive\\cours\\INFO\\S3\\T3\\Projet T3\\Projet T3\\ucEtape.cs" :83 :16) // this (ThisExpression)
%8 = cbde.unknown : none loc("C:\\Users\\fanny\\OneDrive\\cours\\INFO\\S3\\T3\\Projet T3\\Projet T3\\ucEtape.cs" :83 :16) // this.Controls (SimpleMemberAccessExpression)
%9 = cbde.unknown : none loc("C:\\Users\\fanny\\OneDrive\\cours\\INFO\\S3\\T3\\Projet T3\\Projet T3\\ucEtape.cs" :83 :16) // this.Controls.Clear() (InvocationExpression)
%10 = cbde.unknown : none loc("C:\\Users\\fanny\\OneDrive\\cours\\INFO\\S3\\T3\\Projet T3\\Projet T3\\ucEtape.cs" :84 :16) // this (ThisExpression)
%11 = cbde.unknown : none loc("C:\\Users\\fanny\\OneDrive\\cours\\INFO\\S3\\T3\\Projet T3\\Projet T3\\ucEtape.cs" :84 :16) // this.Controls (SimpleMemberAccessExpression)
%12 = cbde.unknown : none loc("C:\\Users\\fanny\\OneDrive\\cours\\INFO\\S3\\T3\\Projet T3\\Projet T3\\ucEtape.cs" :84 :34) // Not a variable of known type: etapeSuiv
%13 = cbde.unknown : none loc("C:\\Users\\fanny\\OneDrive\\cours\\INFO\\S3\\T3\\Projet T3\\Projet T3\\ucEtape.cs" :84 :16) // this.Controls.Add(etapeSuiv) (InvocationExpression)
br ^1

^1: // ExitBlock
return

}
