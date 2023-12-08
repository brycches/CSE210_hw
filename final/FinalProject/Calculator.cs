class Calculator
{
   




    public void the_calculator()
    {
        Move move = new Move();
        Pokemon pokemon = new Pokemon();
        TypeChart typeChart = new TypeChart();
        Console.WriteLine("What is the name of your pokemon?");
        string name = Console.ReadLine();
        List<object> type = pokemon.get_types(name);
        Console.WriteLine(type);
        if (type.Count == 9)
        {
            Console.WriteLine($"Your pokemon {name} is {type[0]} {type[1]} type.");
        }
        else
        {
            Console.WriteLine($"Your pokemon {name} is {type[0]} type.");
        }
        string first_type = "";
        string second_type = "";
        if (type.Count == 9)
        {
            first_type = type[0].ToString();
            second_type = type[1].ToString();
        }
        else
        {
            first_type = type[0].ToString();
        }

        Dictionary<string, Dictionary<string, double>> typeDict = typeChart.GetTypeChart();
        if (type.Count == 8)
        {
            Console.WriteLine($"your type: {type[0]}");
            foreach (var innerKey in typeDict[first_type].Keys)
            {
                double value = typeDict[first_type][innerKey];
                if (value == 1)
                {
                    Console.WriteLine($"{type[0]} is neutrally defensive against {innerKey}");
                }
                else if (value == 2)
                {
                    Console.WriteLine($"{type[0]} is 2x weak against {innerKey}");
                }
                else if (value == 0.5)
                {
                    Console.WriteLine($"{type[0]} is 0.5x resistant to {innerKey}");
                }
                else if (value == 0)
                {
                    Console.WriteLine($"{type[0]} is immune to {innerKey}");
                }
                Console.WriteLine($"{innerKey} Value: {value}");
            }
        }
        else if (type.Count == 9)
        {
            double value1;
            double value2;
            Console.WriteLine($"your types: {type[0]}, {type[1]}");
            // Iterate through the inner dictionary
            foreach (var innerKey in typeDict[first_type].Keys)
            {

                value1 = typeDict[first_type][innerKey];
                foreach (var innerKey2 in typeDict[second_type].Keys)
                {
                    if (innerKey == innerKey2)
                    {
                        value2 = typeDict[second_type][innerKey2];
                        if ((value1 == 1 && value2 == 1)||(value1 == 0.5 && value2 == 2)||(value1 == 2 && value2 == 0.5))
                        {
                            Console.WriteLine($"Your pokemon is neutrally defensive against {innerKey}");
                        }
                        else if (value1 == 2 && value2==2)
                        {
                            Console.WriteLine($"Your pokemon is 4x weak against {innerKey}");
                        }
                        else if ((value1 == 1 && value2==2) || (value1 ==2 && value2 == 1))
                        {
                            Console.WriteLine($"Your pokemon is 2x weak against {innerKey}");
                        }
                        else if ((value1 == 0.5 && value2==1) || (value1 ==1 && value2 == 0.5))
                        {
                            Console.WriteLine($"Your pokemon is 0.5x resistant to {innerKey}");
                        }
                        else if (value1 == 0.5 && value2==0.5)
                        {
                            Console.WriteLine($"Your pokemon is 0.25x resistant to {innerKey}");
                        }
                        else if ((value1 == 0)||(value2 == 0))
                        {
                            Console.WriteLine($"Your pokemon is immune to {innerKey}");
                        }
                    }
                }
            }
        }
        
        if (type.Count == 9)
        {
            int attack = (int)type[4];
            int special_attack = (int)type[6];
            if (attack > special_attack)
            {
                Console.WriteLine("Your pokemon is a physical attacker.");
            }
            else if (attack < special_attack)
            {
                Console.WriteLine("Your pokemon is a special attacker.");
            }
        }
        else if (type.Count == 8)
        {
            int attack = (int)type[3];
            int special_attack = (int)type[5];
            if (attack > special_attack)
            {
                Console.WriteLine("Your pokemon is a physical attacker.");
            }
            else if (attack < special_attack)
            {
                Console.WriteLine("Your pokemon is a special attacker.");
            }
        }
        Dictionary<string, List<object>> move_dict = move.Get_Move_Dict();
        bool done = false;
        while (done == false)
        {
            Console.WriteLine("What is the name of the move you would like to try on this pokemon?");
            string move_name = Console.ReadLine();
            List<object> move_info = move.Get_Move_Info(move_name);
            string move_type = (string)move_info[0];
            if (type.Count == 8)
            {
                double effectiveness = (double)typeDict[first_type][move_type];
                if (effectiveness > 1)
                {
                    Console.WriteLine($"Your move is 2x super effective against {name}.");
                }
                else if (effectiveness == 1)
                {
                    Console.WriteLine($"Your move is neutral against {name}.");
                }
                else if ((effectiveness < 1) && (effectiveness > 0))
                {
                    Console.WriteLine($"Your move is 0.5x not very effective against {name}.");
                }
                else 
                {
                    Console.WriteLine($"{name} is immune to your move.");
                }
            }
            else if (type.Count == 9)

            {
                double effectiveness1 = (double)typeDict[first_type][move_type];
                double effectiveness2 = (double)typeDict[second_type][move_type];
                if ((effectiveness1 == 1 && effectiveness2 == 1)||(effectiveness1 == 0.5 && effectiveness2 == 2)||(effectiveness1 == 2 && effectiveness2 == 0.5))
                {
                    Console.WriteLine($"Your move is neutral against {name}.");
                }
                else if (effectiveness1 == 2 && effectiveness2==2)
                {
                    Console.WriteLine($"Your move is 4x super effective against {name}.");
                }
                else if ((effectiveness1 == 1 && effectiveness2==2) || (effectiveness1 ==2 && effectiveness2 == 1))
                {
                    Console.WriteLine($"Your move is 2x super effective against {name}.");
                }
                else if ((effectiveness1 == 0.5 && effectiveness2==1) || (effectiveness1 ==1 && effectiveness2 == 0.5))
                {
                    Console.WriteLine($"Your move is 0.5x not very effective against {name}.");
                }
                else if (effectiveness1 == 0.5 && effectiveness2==0.5)
                {
                    Console.WriteLine($"Your move is 0.25x not very effective against {name}.");
                }
                else if ((effectiveness1 == 0)||(effectiveness2 == 0))
                {
                    Console.WriteLine($"{name} is immune to your move.");
                }
            }
            Console.WriteLine("Would you like to try another move? [y,n]");
            string again = Console.ReadLine().ToLower();
            if (again != "y")
            {
                done = true;
            }
        };
    }
}