using System;

public class Application
{
	public void fonctionPrincipale ()
	{
	Console.WriteLine("Choisissez votre burger: Boeuf = 1 , Poulet = 2, Poisson = 3");
	

	do {
		int menu =	Utilisateur.saisirEntier(); 
		}
		while( menu < 1 & > 3);
	
	switch (menu)
	{
		case 1:
		Console.WriteLine("Nous préparons votre burger au boeuf");
		break;
		case 2:
		Console.WriteLine("Nous préparons votre burger au poulet");
		break;
		case 3:
		Console.WriteLine("Nous préparons votre burger poisson");
		break;
		default:
		break;
	}	

	}
}









