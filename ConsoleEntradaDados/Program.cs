// See https://aka.ms/new-console-template for more information

Console.WriteLine("Digite uma frase:");
string frase = Console.ReadLine();
Console.WriteLine("A frase é : "+frase);


string s = Console.ReadLine();
string[] vet = s.Split(' '); // OR string[] vet =  Console.ReadLine().Split(' ');
string a = vet[0];
string b = vet[1];
string c = vet[2];

for (int i = 0; i < vet.Length; i++) {
  Console.WriteLine("Você informou na sequencia : "+vet[i]);
}
