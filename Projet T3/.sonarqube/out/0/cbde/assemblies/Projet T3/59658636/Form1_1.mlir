func @_Projet_T3.Form1.Form1_Load$object.System.EventArgs$(none, none) -> () loc("C:\\Users\\fanny\\OneDrive\\cours\\INFO\\S3\\T3\\Projet T3\\Projet T3\\Form1.cs" :34 :8) {
^entry (%_sender : none, %_e : none):
%0 = cbde.alloca none loc("C:\\Users\\fanny\\OneDrive\\cours\\INFO\\S3\\T3\\Projet T3\\Projet T3\\Form1.cs" :34 :32)
cbde.store %_sender, %0 : memref<none> loc("C:\\Users\\fanny\\OneDrive\\cours\\INFO\\S3\\T3\\Projet T3\\Projet T3\\Form1.cs" :34 :32)
%1 = cbde.alloca none loc("C:\\Users\\fanny\\OneDrive\\cours\\INFO\\S3\\T3\\Projet T3\\Projet T3\\Form1.cs" :34 :47)
cbde.store %_e, %1 : memref<none> loc("C:\\Users\\fanny\\OneDrive\\cours\\INFO\\S3\\T3\\Projet T3\\Projet T3\\Form1.cs" :34 :47)
br ^0

^0: // SimpleBlock
%2 = cbde.unknown : none loc("C:\\Users\\fanny\\OneDrive\\cours\\INFO\\S3\\T3\\Projet T3\\Projet T3\\Form1.cs" :36 :24) // new Menu() (ObjectCreationExpression)
%4 = cbde.unknown : none loc("C:\\Users\\fanny\\OneDrive\\cours\\INFO\\S3\\T3\\Projet T3\\Projet T3\\Form1.cs" :37 :12) // this (ThisExpression)
%5 = cbde.unknown : none loc("C:\\Users\\fanny\\OneDrive\\cours\\INFO\\S3\\T3\\Projet T3\\Projet T3\\Form1.cs" :37 :12) // this.Controls (SimpleMemberAccessExpression)
%6 = cbde.unknown : none loc("C:\\Users\\fanny\\OneDrive\\cours\\INFO\\S3\\T3\\Projet T3\\Projet T3\\Form1.cs" :37 :30) // Not a variable of known type: menu
%7 = cbde.unknown : none loc("C:\\Users\\fanny\\OneDrive\\cours\\INFO\\S3\\T3\\Projet T3\\Projet T3\\Form1.cs" :37 :12) // this.Controls.Add(menu) (InvocationExpression)
%8 = cbde.unknown : none loc("C:\\Users\\fanny\\OneDrive\\cours\\INFO\\S3\\T3\\Projet T3\\Projet T3\\Form1.cs" :38 :12) // this (ThisExpression)
%9 = cbde.unknown : none loc("C:\\Users\\fanny\\OneDrive\\cours\\INFO\\S3\\T3\\Projet T3\\Projet T3\\Form1.cs" :38 :12) // this.Text (SimpleMemberAccessExpression)
%10 = cbde.unknown : none loc("C:\\Users\\fanny\\OneDrive\\cours\\INFO\\S3\\T3\\Projet T3\\Projet T3\\Form1.cs" :38 :24) // "School Simulator" (StringLiteralExpression)
br ^1

^1: // ExitBlock
return

}
