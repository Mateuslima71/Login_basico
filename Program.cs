//Sistema de login basico
using System;
using System.Collections.Generic;

class Program
{
    static Dictionary<string, string> usuarios = new Dictionary<string, string>();

    static void Main()
    {
        Console.WriteLine("Bem-vindo ao sistema de login!");

        bool novoUsuarioCriado = CriarNovoUsuario();

        if (novoUsuarioCriado)
        {
            Console.WriteLine("Novo usuário criado com sucesso!");
            bool usuarioAutenticado = FazerLogin();

            if (usuarioAutenticado)
            {
                Console.WriteLine("Login bem-sucedido!");
            }
            else
            {
                Console.WriteLine("Falha no login. Tente novamente.");
            }
        }
        else
        {
            Console.WriteLine("Falha ao criar novo usuário. O programa será encerrado.");
        }

        Console.ReadLine();
    }

    static bool CriarNovoUsuario()
    {
        Console.Write("Digite um nome de usuário para criar: ");
        string novoUsuario = Console.ReadLine();


        if (usuarios.ContainsKey(novoUsuario))
        {
            Console.WriteLine("Erro: O nome de usuário já existe. Escolha outro nome de usuário.");
            return false;
        }
        Console.Write("Digite uma senha para o novo usuário: ");
        string senha = Console.ReadLine();

        while (true)
        {
            
            Console.Write("Confirme sua senha: ");
            string senhaConfirm = Console.ReadLine();


            if (senha == senhaConfirm)
            {
                usuarios.Add(novoUsuario, senha);

                return true;


            }
            else
            {
                Console.WriteLine("As senhas precisam ser iguais!");
            }
        }
        

    }

    static bool FazerLogin()
    {
        Console.Write("Digite seu nome de usuário: ");
        string nomeUsuario = Console.ReadLine();

        Console.Write("Digite sua senha: ");
        string senha = Console.ReadLine();


        if (usuarios.ContainsKey(nomeUsuario) && usuarios[nomeUsuario] == senha)
        {
            return true;
        }

        return false;
    }
}