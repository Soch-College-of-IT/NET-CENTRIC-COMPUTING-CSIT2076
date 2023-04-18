 // Atm MAchine 

 /* constrains 
 Bank user
    -firstname 
    -lastname
    -cardnumber
    -Secret-pin
    -$$ balance
 */

 /* 
 To run the app 
 ```bash
 cd AtmMachine
 dotnet build . 
 dotnet run .
 ```
 use any of the static users below to check the app
 for example 
 ```bash
    Welcome To TvShow ATM
    please Insert your card num :125123
    please Enter your Pin :: 1236
    please choose options
    1. Deposit Money
    2. Withdraw Money
    3. Check Balance
    4. Exit
    
    1
    How much Rs. you like to deposite ? : 1000
    !! Thank you for Depositing Money !!
    Your new balance is :78000.78
    ```
 
 */
using System;
namespace AtmMachine{
public class CardHolder{
string cardNum;
int pin;
string firstname;
string lastname;
double balance;


public CardHolder(string cardNum,int pin,string firstname,string lastname,double balance){
    this.cardNum=cardNum;
    this.pin=pin;
    this.firstname=firstname;
    this.lastname=lastname;
    this.balance=balance;
}

public string getcardNum(){
    return cardNum;
}
public int getPinNum(){
    return pin;
    
}
public String getFirstName(){
    return firstname;
}
public String getLastName(){
    return lastname;
}
public double getBalance(){
    return balance;
}

public void setcardNum(string newCardNum){
    cardNum=newCardNum;
}
public void setPin(int newpin){
    pin=newpin;
}
public void setFirstName(String newFirstname){
    firstname=newFirstname;
}
public void setLastName(String newLasttname){
    lastname=newLasttname;
}
public void setBalance(double newBalance){
    balance=newBalance;
}

public static void Main(string[] args){
    void printOptions(){
        Console.WriteLine("Welcome To TvShow ATM!!");
        Console.WriteLine("please choose options");
        Console.WriteLine("1. Deposit Money");
        Console.WriteLine("2. Withdraw Money");
        Console.WriteLine("3. Check Balance");
        Console.WriteLine("4. Exit");
        
        
    }
    void deposit(CardHolder currentUser){
        Console.WriteLine("How much Rs. you like to deposite ? : ");
        double deposit = Double.Parse(Console.ReadLine());
        currentUser.setBalance(deposit);
        Console.WriteLine("!! Thank you for Depositing Money !! \n Your new balance is :"+currentUser.getBalance());

    }
    void WithdrawMoney(CardHolder currentUser){
        Console.WriteLine("How much money you like to withdraw  ?? : ");
        double withdrawal = Double.Parse(Console.ReadLine());
        if (currentUser.getBalance()<withdrawal) {
            Console.WriteLine("Insufficient Balanve :( ");
        }
        else {
            Console.WriteLine("You have Succesfully Withdraw RS . "+withdrawal);
            currentUser.setBalance(currentUser.getBalance()-withdrawal);
            Console.WriteLine("Your new balance is RS . "+currentUser.getBalance());

        }

    }
    void Checkbalance (CardHolder currentUser){
        Console.WriteLine("Current balance : "+currentUser.getBalance());

    }
    List<CardHolder> CardHolders = new List<CardHolder>();
    CardHolders.Add(new CardHolder("123123",1234,"Tirion","Lannister",800.445));
    CardHolders.Add(new CardHolder("124123",1235,"Jon","Snow",400.88));
    CardHolders.Add(new CardHolder("125123",1236,"Jessy","Pinkman",78000.780));
    CardHolders.Add(new CardHolder("126123",1237,"Walter","White",100000.599));

    Console.WriteLine("Welcome To TvShow ATM ");
    Console.WriteLine("please Insert your card num :");
    string debitCardNum= "";
    CardHolder currentUser;

    while (true){
        try {
            debitCardNum = Console.ReadLine();
            currentUser =CardHolders.FirstOrDefault(a => a.cardNum == debitCardNum);
            if (currentUser != null ){break;}
            else {Console.WriteLine("Card Number didnt match try Again ");}
        }
        catch {Console.WriteLine("Card Number didnt match try Again ");}
    }
    Console.WriteLine("please Enter your Pin :: ");
    int userpin = 0;
    while(true){
        try{
            userpin= int.Parse(Console.ReadLine());
            if (currentUser.getPinNum()==userpin){break;}
            else {Console.WriteLine("Incorrect pin please try again");}
        }
        catch {Console.WriteLine("Incorrect pin");}
    }
    Console.WriteLine("Welcome"+currentUser.getFirstName() + currentUser.getLastName()+ ":)");
    int option = 0;
    do {
        printOptions();
        try {
            option = int.Parse(Console.ReadLine());
        }
        catch {}
        if (option == 1) { deposit(currentUser);}
        else if (option == 2) {WithdrawMoney(currentUser);}
        else if (option == 3) {Checkbalance(currentUser);}
        else if (option ==4 ) {break;}
        else {option = 0;}

    }while(option !=4);
    Console.WriteLine("Thank You have a nice Day :)");
}

}
}
