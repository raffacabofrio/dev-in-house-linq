﻿public class ConstructorDestructor
    {
        public void Exemplos()
        {
            // ExemploMultiplosConstrutores();
            // ExemploCopy();
            // ExemploConstrutorEncadeado();
            // ExemploStaticCtor();
            // ExemploSingleton();
            ExemploDestructor();
        }

        void ExemploStaticCtor()
        {
            var user1 = new UserStaticCtor();
            var user2 = new UserStaticCtor();
            var user3 = new UserStaticCtor();
            var user4 = new UserStaticCtor();
            var user5 = new UserStaticCtor();

            Console.WriteLine("\nPress Enter Key to Exit..");
            Console.ReadLine();
        }

        void ExemploMultiplosConstrutores()
        {
            User user = new User();
            Console.WriteLine(user.name);
            Console.WriteLine(user.location);

            var user2 = new User("Mauro");
            Console.WriteLine(user2.name);
            Console.WriteLine(user2.location);
    }

        void ExemploConstrutorEncadeado()
        {
            var user1 = new UserEncadeado(" a", "turma dev-in-house");
        }

        void ExemploCopy()
        {
            var user2 = new User("Johann");
            Console.WriteLine(user2.name);
            Console.WriteLine(user2.location);


            var user3 = new User(user2);
            Console.WriteLine("Fiz uma cópia do user2. Vamos ver como ficou:");
            Console.WriteLine(user3.name);
            Console.WriteLine(user3.location);
        }


        void ExemploSingleton()
        {
            var user = UserPrivateCtor.GetInstanceSingleton();
            var user2 = UserPrivateCtor.GetInstanceSingleton();
            var user3 = UserPrivateCtor.GetInstanceSingleton();
            var user4 = UserPrivateCtor.GetInstanceSingleton();
            var user5 = UserPrivateCtor.GetInstanceSingleton();

            Console.WriteLine("\nPress Enter Key to Exit..");
            Console.ReadLine();
        }

        void ExemploDestructor()
        {
            ExemploDestructor02();

            GC.Collect();
            Console.ReadLine();
        }

        void ExemploDestructor02()
        {
            var user = new UserWithDestructor();
        }
    }

    public class User
    {
        public string name, location;

        // construtor padrão
        public User()
        {
            name = "Suresh Dasari";
            location = "Hyderabad";
        }

        // construtor parametrizado
        public User(string name)
        {
            this.name = name;
            location = "São Paulo";

            Console.WriteLine("Construtor com parâmetro");
        }

        // construtor copy
        public User(User user)
        {
            name = user.name;
            location = user.location;
        }
    }

    public class UserEncadeado
    {
        public UserEncadeado()
        {
            Console.WriteLine("1 - Olá, ");
        }

        public UserEncadeado(string a) : this()
        {
            Console.WriteLine("2 - " + a);
        }

        public UserEncadeado(string a, string b) : this("bem vindo")
        {
            Console.WriteLine("3 - " + a + " " + b);
        }
    }

    public class UserStaticCtor
    {
        // Static Constructor
        static UserStaticCtor()
        {
            Console.WriteLine("I am Static Constructor");
        }

        // Default Constructor
        public UserStaticCtor()
        {
            Console.WriteLine("I am Default Constructor");
        }
    }

    public class UserPrivateCtor
    {
        private UserPrivateCtor()
        {
            Console.WriteLine("I am Private Constructor");
        }

        public static string? name, location;

        private static UserPrivateCtor _instance;

        // Default Constructor
        public UserPrivateCtor(string a, string b)
        {
            name = a;
            location = b;
        }

        public static UserPrivateCtor GetInstanceSingleton()
        {
            if (_instance == null)
            {
                Console.WriteLine("Criando minha instância pela primeira vez.");
                _instance = new UserPrivateCtor();
            }
            else
            {
                Console.WriteLine("A instância Já foi criada.");
            }

            return _instance;
        }
    }

    public class UserWithDestructor
    {
        public UserWithDestructor()
        {
            Console.WriteLine("O MÉTODO CONSTRUTOR FOI INVOCADO.");
        }

        // Destructor
        ~UserWithDestructor()
        {
            Console.WriteLine("O MÉTODO DESTRUIDOR FOI INVOCADO.");
        }
    }

