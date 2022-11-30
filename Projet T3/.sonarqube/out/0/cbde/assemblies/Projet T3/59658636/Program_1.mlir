func @_Projet_T3.Program.Main$$() -> () loc("C:\\Users\\fanny\\OneDrive\\cours\\INFO\\S3\\T3\\Projet T3\\Projet T3\\Program.cs" :10 :8) {
^entry :
br ^0

^0: // SimpleBlock
// Entity from another assembly: Application
%0 = cbde.unknown : none loc("C:\\Users\\fanny\\OneDrive\\cours\\INFO\\S3\\T3\\Projet T3\\Projet T3\\Program.cs" :13 :12) // Application.EnableVisualStyles() (InvocationExpression)
// Entity from another assembly: Application
%1 = constant 0 : i1 loc("C:\\Users\\fanny\\OneDrive\\cours\\INFO\\S3\\T3\\Projet T3\\Projet T3\\Program.cs" :14 :58) // false
%2 = cbde.unknown : none loc("C:\\Users\\fanny\\OneDrive\\cours\\INFO\\S3\\T3\\Projet T3\\Projet T3\\Program.cs" :14 :12) // Application.SetCompatibleTextRenderingDefault(false) (InvocationExpression)
// Entity from another assembly: Application
%3 = cbde.unknown : none loc("C:\\Users\\fanny\\OneDrive\\cours\\INFO\\S3\\T3\\Projet T3\\Projet T3\\Program.cs" :15 :28) // new Form1() (ObjectCreationExpression)
%4 = cbde.unknown : none loc("C:\\Users\\fanny\\OneDrive\\cours\\INFO\\S3\\T3\\Projet T3\\Projet T3\\Program.cs" :15 :12) // Application.Run(new Form1()) (InvocationExpression)
br ^1

^1: // ExitBlock
return

}
