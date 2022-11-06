using System.Security.Cryptography;
//array 20 name caves
string[] caves = new string[20];
Random rnd = new Random();
int x;
//array 20 fill null values
for (int i = 0; i < 20; i++)
{
    caves[i] = "null";
}
 
//fill array random values lambda
var checkreword=caves.Any(x => x == "reword");
if (checkreword == false)
{
   
     x = rnd.Next(0, 20);
    caves[x] = "reword";
   
}

//fill array random values pit
for (int i = 0; i < 2; i++)
{
    
   
     x = rnd.Next(0, 20);
    while (caves[x] == "reword" && caves[x] == "pit")
    {
        x = rnd.Next(0, 20);
    }
    
   
    caves[x] = "pit";
    
}

//fill array random values bat

   
     x = rnd.Next(0, 20);
    while (caves[x] == "reword" && caves[x] == "pit" )
    {
        x = rnd.Next(0, 20);
    }
    
   
    caves[x] = "bat";


    //print array
    for (int i = 0; i < 20; i++)
    {
        System.Console.WriteLine("caves"+i+ ":"+ caves[i]);
    }
    


    //player start
    int player = 0;
     do
     {
        System.Console.WriteLine("enter number 1-20");
         player = Convert.ToInt32(Console.ReadLine());
        if (player > 20 || player < 0)
        {
            System.Console.WriteLine("enter number 1-20");
        }
        else
        {
            if (caves[player] == "reword")
            {
                System.Console.WriteLine("you win");
                System.Console.WriteLine("are you want play again ");
            }
            else if (caves[player] == "pit")
            {
                System.Console.WriteLine("you fall in pit");
            }
            else if (caves[player] == "bat")
            {
                System.Console.WriteLine("you fall in bat");
            }
            else
            {
                var stepnext=caves[player + 1];
                var stepback=caves[player - 1];
                if(stepback=="pit" || stepback=="bat" || stepnext=="pit" || stepnext=="bat")
                {
                    System.Console.WriteLine("you hear bat or pit");
                }
                else{
                    System.Console.WriteLine("you are safe try again");
                }

                
            }
        }
        
     } while (caves[player] =="null" || caves[player] =="reword");



   

    





