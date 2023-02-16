using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication1
{
    class Program
    {
        public class customer// The main class that contains all of the string and int varibles that will be used by the program to print out and calculate the cost, room and other important variables the guest will need
        {

            private string Cust_first_name;
            private string Cust_last_name;
            private string Cruise_company;
            private string Room_type;
            private int Accomadating_guests;
            private int Cruise_length;
            private int Guest_age;
            private int Room_num;

            public customer()// this is the null constructor that sets every value to nothing
            {
                Cust_first_name = "";
                Cust_last_name = "";
                Cruise_company = "";
                Room_type = "";
                Accomadating_guests = 0;
                Cruise_length = 0;
                Guest_age = 0;
                Room_num = 0;
            }

            // this is the constructor that takes in 4 strings and 4 int varibles that will be used throughout the code to set each variable to a caertian value, they will be used mainly for the tostring and calculate price class
            public customer(string C_first_name, string C_last_name, string C_company, string R_type, int A_guests, int C_length, int G_age, int R_num)
            {
                Cust_first_name = C_first_name;
                Cust_last_name = C_last_name;
                Cruise_company = C_company;
                Room_type = R_type;
                Accomadating_guests = A_guests;
                Cruise_length = C_length;
                Guest_age = G_age;
                Room_num = R_num;
            }
            public string CalculatePrice()// this is the calculateprice function that will calculate the total cost of the cruise you will be taking, 
            {
                int Cruiseline_cost = 0;// cruiseline cost varible
                int Room_cost = 0;// room cost varible
                double HST_GST_tax = 1.13;// Canadian tax varible

                if (Cruise_company.Equals("Carnival Cruise Line"))// this if statement says that if the cruise company that the user has selected equals the carnival cruise line then it will run through this statement
                {
                    Cruiseline_cost = 1000;// makes the cruiseline_cost varible equal 1000
                }

                //***** there are 4 of these types of statements, each one does the exact same thing as above but the diffeence is the cruise name and cost

                if (Cruise_company.Equals("Disney Cruise Line"))
                {
                    Cruiseline_cost = 2000;
                }
                if (Cruise_company.Equals("Norwegian Cruise Line"))
                {
                    Cruiseline_cost = 1500;
                }
                if (Cruise_company.Equals("Mediterranean Cruise Line"))
                {
                    Cruiseline_cost = 2500;
                }



                if (Room_type.Equals("Single room"))// this is an if statement that says if the users selection for thier room equals to Single room, then it will run through this statement
                {
                    Room_cost = 300;// makes the room cost equal to 300
                }

                //**** there are 5 more of these statements that do the same thing as above, the only difference is the room name and the cost of each room

                if (Room_type.Equals("Double room"))
                {
                    Room_cost = 450;
                }
                if (Room_type.Equals("Family room"))
                {
                    Room_cost = 650;
                }
                if (Room_type.Equals("Deluxe room"))
                {
                    Room_cost = 900;
                }
                if (Room_type.Equals("Presidential suite"))
                {
                    Room_cost = 1300;
                }
                if (Room_type.Equals("Pent house"))
                {
                    Room_cost = 2000;
                }


                double Total_cost = (Cruiseline_cost + Room_cost + (Accomadating_guests * 120)) * Cruise_length * HST_GST_tax;// creates a double variable that will calculate the total cost of the cruise for how many people will be attending
                String outputprice = "Cruise Line cost $" + Cruiseline_cost;// creates a string varible called outputprice which will store the cruise cost
                outputprice += "\nRoom price: $" + Room_cost;// adds to the outputprice varible and adds the room cost to the variable
                outputprice += "\nCost for accomodating guests: $" + (Room_cost + Accomadating_guests * 120);// adds to the outputprice varible and adds the cost for the accomodating guest cost to the variable
                outputprice += "\nPrice For Days Booked: $" + (Cruise_length * (Room_cost + (Accomadating_guests * 120)));// adds to the outputprice varible and adds the cost for the days stayed on the cruise to the variable
                outputprice += "\nSales Tax: " + HST_GST_tax + "%";// adds to the outputprice varible and adds the tax that will be implied on the total cost to the variable
                outputprice += "\nThe total price will be $" + Total_cost;// this will store the total cost of the whole cruise
                return outputprice;// returns everything allowing it to display and store correctly 
            }

            public String toString()// tostring function that will display all of the users info
            {
                String output = "Customer first name: " + Cust_first_name + "\n";// creates a varible called output, this stores the customers first name
                output += "Customer last name: " + Cust_last_name + "\n";// adds to output and stroes the last name
                output += "Room Type: " + Room_type + "\n";// adds to output and stores the room type 
                output += "ber of people in the Room: " + Accomadating_guests + "\n";// adds to the output and stores the number of people attending 
                output += "Customer Age: " + Guest_age + "\n";// adds to the output and stores the customer age
                output += "Cruise Line: " + Cruise_company + "\n";// adds to the output and stores the cruise company the user selected
                output += "Days staying: " + Cruise_length + "\n";// adds to the output and stores the length of the cruise
                output += "Room Number: " + Room_num + "\n";// adds to the output and stores the room number
                return output;// returns everything allowing it to store and display correctly
            }

        }
        static void Main(string[] args)// main program
        {
            Random rnd = new Random();// random number generator
            int num = rnd.Next(100000000);// creates a int varible called num and tells it to create a random number from  0 - 100000000


            bool Program = true;// bool varible called program that is intialized as true
            bool program2 = true;// bool varible called program2 that is intialized as true

            bool Options = true;// bool varible called options that is intialized as true
            bool Select_cruise = true;// bool varible called selectcruise that is intialized as true
            bool Select_room = true;// bool varible that is called select room that is intialized as true
            int Input1 = 0;// int varible that is set equal to 0 
            string C_first_name = ""; // string varible that is set to nothing
            string C_last_name = ""; // string varible that is set to nothing
            string C_company = ""; // string varible that is set to nothing
            string R_type = ""; //string varible that is set to nothing
            int A_guests = 0; //int varible that is set to 0 
            int C_length = 0; //int varible that is set to 0
            int G_age = 0;// int varible that is set to 0
            string R_num = "";// string varible that is set to nothing

            Console.WriteLine("---------------------------------------------------");
            Console.WriteLine("Hello, welcome to Bhaavan's Cruise Line agency");
            Console.WriteLine("---------------------------------------------------");

            Console.WriteLine("\nHow would you like to continue");

            while (Options == true)// while loop that says that if the options bool varible is true then it will run through this loop
            {
                Console.WriteLine("---------------------------------------------------------------");
                Console.WriteLine("[1] Book Reservation, [2] Cancel Reservation, [3] Exit Program");
                Console.WriteLine("---------------------------------------------------------------");

                try // this is a try catch that will check to see if the input is applicable and usebale, if it is then it will go through the try, if not it will go to the catch
                {
                    Input1 = Convert.ToInt32(Console.ReadLine());// sets the input1 varible equal to the users input and converts it to an int varible 
                }
                catch (System.FormatException)// this is the catch part of the try catch, it will display this below value if the program find that the input above was incorrect
                {
                    Console.WriteLine("\nWrong value");
                }
                if (Input1 == 1)// this is an if statement that says if the user has inputted the value of 1 then it will run through this statement
                {
                    Program = true;// sets the program bool value to true
                    break;// breaks out of the loop
                }
                else if (Input1 == 2)// this is an if statement that says if the users input equals 2 then it will run through this statement
                {
                    Program = false;// turns the program bool into false
                    program2 = false;// turns the program2 bool into false
                    break;// breaks out the loop
                }
                else if (Input1 == 3)// this is an if statment that says if the users input equals 3 then it will run through this statement
                {
                    Console.WriteLine("Thank you for visitng Bhaavan's Cruise Line Agency, have a great day");
                    break;// breaks out of the program

                }
                else// else statements that say if the user enters anything else it will go through this
                {
                    Console.WriteLine("\nThere is a error in the value you have inputted, please try again!\n");
                }
            }


            while (Program == true)// this is a while loop that says if the program bool vairble is equal to true then it will run through this while loop
            {
                bool Guest_age_check = true;// bool varible called Guest_age_check that is intialized as true
                bool Accomodating_guest_check = true;// bool varible called Accomodating_guest_check that is intialized as true
                bool Cruise_lenght_check = true;// bool variable called Cruise_lenght_check that is intialized as true 

                Console.WriteLine("");
                Console.Write("Please enter your first name: ");
                C_first_name = Console.ReadLine();// reads in the users input for thier first name

                Console.Write("Please enter your last name: ");
                C_last_name = Console.ReadLine();// reads in the users input for thierm last name 

                Console.Write("Please input your age: ");
                while (Guest_age_check == true)// while loop that says if the Guest_age_check is equal to true then it will run through the loop
                {
                    try // this is a try catch that will check to see if the input is applicable and usebale, if it is then it will go through the try, if not it will go to the catch
                    {
                        G_age = Convert.ToInt32(Console.ReadLine());// reads in the users input for thier age, and then converts it to a int varibable and reads it in
                        Guest_age_check = false;
                    }
                    catch (System.FormatException)// this is the catch part of the try catch, it will display this below value if the program find that the input above was incorrect
                    {
                        Console.WriteLine("\nError. You must enter a number. Please Try Again");
                    }
                }
                Console.Write("Please input how many total people will attend the hotel room: ");
                while (Accomodating_guest_check == true)// this is a while loop thats says that if Accomodating_guest_check is equal to true then it will run through this loop
                {
                    try // this is a try catch that will check to see if the input is applicable and usebale, if it is then it will go through the try, if not it will go to the catch
                    {
                        A_guests = Convert.ToInt32(Console.ReadLine());
                        Accomodating_guest_check = false;
                    }
                    catch (FormatException)// this is the catch part of the try catch, it will display this below value if the program find that the input above was incorrect
                    {
                        Console.WriteLine("\nError. You must enter a number. Please Try Again");
                    }
                }
                while (Cruise_lenght_check == true)// this is a for loop that says if the Cruise_lenght_check is equal to ture then it will run through this loop
                {
                    Console.WriteLine("-----------------------------------------------------------------------------------------------------------------------------");
                    Console.WriteLine("\nWe offer 3 different Cruise lengths");
                    Console.WriteLine("\n3 days -- 5 days -- 7 days");
                    Console.Write("\nPlease enter the length of the cruise you would like to attend (Please input a integer value of 3,5, or 7): ");
                    try // this is a try catch that will check to see if the input is applicable and usebale, if it is then it will go through the try, if not it will go to the catch
                    {
                        C_length = Convert.ToInt32(Console.ReadLine());// this reads in the users input and converts it into a int varible and stores it in the C_length variable
                        if (C_length == 3 || C_length == 5 || C_length == 7)// this is an if statement that says if C_length is equal to 3,5, or 7 then it will run through this loop
                        {

                            Cruise_lenght_check = false;// changes cruise length bool into false
                        }
                        else// else for any other input by the user
                        {
                            Console.WriteLine("\nError. You must enter a number. Please Try Again");
                        }
                    }
                    catch (FormatException)// this is the catch part of the try catch, it will display this below value if the program find that the input above was incorrect
                    {
                        Console.WriteLine("\nError. You must enter a number. Please Try Again");
                    }
                }

                while (Select_cruise == true)// this is a while loop that says if the select_cruise is true then it will run through this loop
                {
                    int Input2 = 0;// creates a int varible called input2 this is set to 0 

                    Console.WriteLine("-----------------------------------------------------------------------------------------------------------------------------");

                    Console.WriteLine("\nOur Agency offers four different cruise lines at different rates, these Cruise Lines are:");
                    Console.WriteLine("");
                    Console.WriteLine("Carnival Cruise Line - $1000\nDisney Cruise Line - $2000\nNorwegian Cruise Line - $1500\nMediterranean Cruise Line - $2500");
                    Console.WriteLine("Please enter the desired Cruise Line");

                    Console.WriteLine("\n[1] Carnival Cruise Line, [2] Disney Cruise Line, [3] Norwegian Cruise Line, [4] Mediterranean Cruise Line");
                    try // this is a try catch that will check to see if the input is applicable and usebale, if it is then it will go through the try, if not it will go to the catch
                    {
                        Input2 = Convert.ToInt32(Console.ReadLine());// this takes in the user input and converts it into a int varibale and then stores it into the Input2 variable
                    }
                    catch (System.FormatException)// this is the catch part of the try catch, it will display this below value if the program find that the input above was incorrect
                    {
                        Console.WriteLine("\nError.");
                    }
                    if (Input2 == 1)// this says that if the user input is equal to 1 then it will go through this statement
                    {
                        C_company = "Carnival Cruise Line";// defines that C_company is equal to Carnival Cruise Line, since this is defnied it will now go through the CalculatePrice function because there is a condiotn in that function, that makes this equal to the user input
                        Select_cruise = false;// turns select_cruise false
                    }

                    //***** the next 3 if statements are the exact same thing as above, the main difference is that the user input for which company he would like take a cruise on, and what the C_company varible equals, it will do the exact same thing as above
                    if (Input2 == 2)
                    {
                        C_company = "Disney Cruise Line";
                        Select_cruise = false;
                    }
                    if (Input2 == 3)
                    {
                        C_company = "Norwegian Cruise Line";
                        Select_cruise = false;
                    }
                    if (Input2 == 4)
                    {
                        C_company = "Mediterranean Cruise Line";
                        Select_cruise = false;
                    }
                }


                while (Select_room == true)// while loop that says, if the select_room bool variable is equal to true then it will run through this while loop
                {
                    int Input3 = 0;// creates a new int varibale called Input3 and sets it equal to 3
                    Console.WriteLine("-----------------------------------------------------------------------------------------------------------------------------");

                    Console.WriteLine("\nThis cruise line offers 6 different types of rooms");
                    Console.WriteLine("Which room would you like to book you book?");
                    Console.WriteLine("");
                    Console.WriteLine("\nSingle room - $300\nDouble room - $450\nFamily room - $650\nDeluxe room - $900\nPresidential suite - $1300\nPent house - $2000");

                    Console.WriteLine("\n[1] Single room, [2] Double room, [3] Family room, [4] Deluxe suite, [5] Presidential suite, [6] Pent house");
                    try // this is a try catch that will check to see if the input is applicable and usebale, if it is then it will go through the try, if not it will go to the catch
                    {
                        Input3 = Convert.ToInt32(Console.ReadLine());// takes the users input and converts it into a int varibale and then reads it into the input3 varible and stores it
                    }
                    catch (System.FormatException)// this is the catch part of the try catch, it will display this below value if the program find that the input above was incorrect
                    {
                        Console.WriteLine("\nError.");
                    }
                    if (Input3 == 1)// this is an if statement that says if the user input equals to 1 then it will go through this loop, 
                    {
                        R_type = "Single room"; // this says that if the room that the user slected is equal to Single Room then it will take that, in it will tehn go to the CalculatePrice function becuase in the function there is a definition for this and then will take in the price
                        Select_room = false;// turns the Select_room bool variable into false
                    }

                    //***** the next 5 if statements are the exact same thing as above, the main difference is that the user input for which room he would like take a cruise on, and what the R_type varible equals, it will do the exact same thing as above
                    else if (Input3 == 2)
                    {
                        R_type = "Double room";
                        Select_room = false;
                    }
                    else if (Input3 == 3)
                    {
                        R_type = "Family room";
                        Select_room = false;
                    }
                    else if (Input3 == 4)
                    {
                        R_type = "Deluxe room";
                        Select_room = false;
                    }
                    else if (Input3 == 5)
                    {
                        R_type = "Presidential suite";
                        Select_room = false;
                    }
                    else if (Input3 == 6)
                    {
                        R_type = "Pent house";
                        Select_room = false;
                    }
                    else
                    {
                        Console.WriteLine("\nYou have inputted an invalid option. Please try again!\n");
                    }
                }
                break;// breaks it out of the loop
            }
            while (program2 == true)// this is a while loop that says that if the program2 bool variable is equal to true then it will run through this loop 
            {

                bool room = false;// this creates a bool variable called room and sets it to false
                bool roomCheck = true;// this creates a bool variable called roomCheck and sets it to false
                String[] fileName = File.ReadAllLines(@"C:\Users\bhaav\OneDrive\Desktop\Cruise.txt");// creates a string array called file name and reads in the file so it can acess the data located in the file
                var lines = File.ReadAllLines(@"C:\Users\bhaav\OneDrive\Desktop\Cruise.txt");// creates a var called lines, this is where the file is read in once again and equals it to lines
                Console.WriteLine("-----------------------------------------------------------------------------------------------------------------------------");

                Console.WriteLine("These are the available rooms for a " + R_type + ":\n");// this prints out the users selection for the room and tells them that here are the options for your room 
                for (int i = 0; i < lines.Length; i++)// for loop that will be used in order to traverse through the lines of the file that is being read in, it takes in the lines length which means it will not end until all of the lines in the file have been read, it increments by 1 
                {
                    if ((fileName[i].Contains("Vacant")) && (fileName[i].Contains(R_type)))// this is an if statement that says if the file contains the word Vacant and contains the users room type selectiion it will run through the statement
                    {
                        Console.WriteLine(fileName[i]);// prints out all of the options that satisfy the if statement above
                        room = true;// turn the room bool variable into true 
                    }
                }
                while (room == false)// this is a while loop that says that if the the room variable is equal to false then it will run through this statement
                {
                    Console.WriteLine("\nThere are no available rooms for the " + R_type + ":\n");// syays that there is no room avaible for the users selection

                }
                while (room == true)// this is a while loop that says if the the room variable is equal to true then it will run through this loop
                {
                    Console.Write("\nPlease enter the room number you will be booking: ");
                    try // this is a try catch that will check to see if the input is applicable and usebale, if it is then it will go through the try, if not it will go to the catch
                    {
                        R_num = Console.ReadLine();// stores the user input in the varible R_num 
                        if (R_num.Length == 3)// this says that if the length of the user input is equal to 3 it will run through this loop 
                        {
                            for (int i = 0; i < lines.Length; i++)// this is a for loop that looks at the lines in the file and starts of at line 0 and continues on until the length of the lines in the file and increments everytime
                            {
                                if ((fileName[i].Contains("Vacant")) && (fileName[i].Contains(R_num)) && (fileName[i].Contains(R_type)))// this is a if statement that says if the file contians the word Vacant and the users room num and the users room type then it will go through this statement
                                {
                                    Console.WriteLine("-----------------------------------------------------------------------------------------------------------------------------");

                                    Console.WriteLine("You have now booked Room: " + R_num + "\n");// tells the user there room has been booked
                                    int Room_number = Convert.ToInt32(R_num);// creates a new int varible called Room_number and stores the R_num value into it
                                    customer customer1 = new customer(C_first_name, C_last_name, C_company, R_type, A_guests, C_length, G_age, Room_number);// this creates a brand new customer using the customer class called cutomer1 and stores in all of the defining variables that define that cusomter 
                                    Console.WriteLine(customer1.toString());// prints out the customer using the tostring method near the top of the code
                                    Console.WriteLine(customer1.CalculatePrice());//prints out the price for the customer using the CalculatePrice method near the top of the code
                                    int availibility = 2;// creates a varible called availablitty and makes it equal to 2 
                                    lineChanger(availibility, R_type, R_num, C_company, num);// this calls the linechanger function near the bottom of the code to change the file 

                                    room = false;// changes room bool to false
                                    roomCheck = false;// changes roomCheck bool to false
                                }
                            }

                        }
                        if (roomCheck == true)// this is an if statement that says if roomCheck is true then it will run through this statement
                        {
                            Console.WriteLine("You must enter a vacant " + R_type + "room number. Please Try Again.");// asks the user to try again and input
                        }
                    }
                    catch (System.FormatException)// this is the catch part of the try catch, it will display this below value if the program find that the input above was incorrect
                    {
                        Console.WriteLine("\nError. You must enter a number. Please Try Again");
                    }
                }
                Console.WriteLine("\nYour room is now booked!");

                Console.WriteLine("Your confirmation number is: " + num);
                Console.WriteLine("Please use this number if you would like to cancel your booking");
                Console.WriteLine("\nThank you, hit any key to close program ");
                Console.ReadKey();
                program2 = false;// turns program2 bool into false
            }
            while (Program == false)// this is a while loop that says if Program is fale then it will run through this statement
            {
                String[] fileName = File.ReadAllLines(@"C:\Users\bhaav\OneDrive\Desktop\Cruise.txt");//creates a string array called file name and reads in the file so it can acess the data located in the file
                var lines = File.ReadAllLines(@"C:\Users\bhaav\OneDrive\Desktop\Cruise.txt");// creates a var called lines, this is where the file is read in once again and equals it to lines
                Console.Write("Thank You, can you please enter your room number here: ");
                R_num = Console.ReadLine();// reads in the user entry for the room number
                Console.WriteLine("");
                Console.Write("please enter your room type (Make sure the first letter is a capital of the first word and there is a space between the two words): ");
                R_type = Console.ReadLine();// reads in the users input for the room type
                Console.WriteLine("");
                Console.Write("Please enter your confirmation number: ");// asks the user for the confirmation number
                num = int.Parse(Console.ReadLine());// reads in the users confirmation number

                if (R_num.Length == 3)// this says that if the users input for the room num is 3 numbers long it will go through this statement 
                {
                    for (int i = 0; i < lines.Length; i++)// this is a for loop that looks at the lines in the file and starts of at line 0 and continues on until the length of the lines in the file and increments everytime
                    {
                        if ((fileName[i].Contains("Occupied")) && (fileName[i].Contains(R_num)) && (fileName[i].Contains(R_type)) && (fileName[i].Equals((num))))// this is an if statement that says if the file contains the word Occupied, the room number or the user, room type of the user and the confirmation number then it will run through this loop
                        {
                            Console.WriteLine("We have found your room, your booking has been cancelled");
                            int availibility = 1;// creates a int varibale called availibility and sets it value to 1
                            lineChanger(availibility, R_type, R_num, C_company, num);// calls the linechanger varible which changes the line in the file
                            Console.WriteLine("Thank you for using Bhaavan's Cruise Line Agency");
                            break;//breaks out of the statement
                        }
                        else
                        {
                            Console.WriteLine("You have made an incorrect entry, please try again");

                        }

                    }
                    break;// this breaks it out of the if statement 
                }
                Console.WriteLine("\nThank you, hit any key to close program ");
                break;// breaks out of the while loop

            }
        }
        static void lineChanger(int availability, string suitename, string roomNum, string company, int rndnum)// this is the lineChanger function, the mian point of this function is to change the lines within the file that we are storing our data to, it takes in three strings and two ints, this function checsk what the availibility varible is equal to and goes according to that 
        {
            string fileNamee = @"C:\Users\bhaav\OneDrive\Desktop\Cruise.txt";// this intializes the fileName and creates the file path that we will be editing
            string newText = "";// creates a new string avarible called newText and sets it equal to nothing
            if (availability == 1)// this says that if availbity is equal to 1 it will go through this statement
            {
                newText = roomNum + " - " + suitename + " - " + "Vacant";// stores everything in the newText variable, it takes in the room num suitename into what the user has inputted which should make no difference to the text in the file as the user inputts the same data they retrived, and then changes the occupied to Vacant, because this line is spcifically meant for cancelation
            }
            if (availability == 2)// this says that if availbity is equal to 2 it will go through this statement
            {
                newText = roomNum + " - " + suitename + " - " + "Occupied" + " - " + company + " - " + rndnum;// stores everything in the NewText varible and takes in the room num suitname cruise company and the confirmation number and stores it all, it will also make sure that line is changed from Vacant to Occupied because this line is spcifically meant for booking the room 
            }
            int line_to_edit = Convert.ToInt32(roomNum.Substring(1, 2));// creates a new int variable called line to edit, it then converts it to an int and takes in the substring for the the room num and retriveves the 1 and 2 position of the line
            string[] arrLine = File.ReadAllLines(fileNamee);// creates a new string array called arrline, it is equal to the file 
            arrLine[line_to_edit] = newText;// arrline is the file and then passes in the line to edit and equals it to newText which will change the line in the file
            File.WriteAllLines(fileNamee, arrLine);// creates a new file and then writes the specified string in the file and closes the file
        }
    }
}


