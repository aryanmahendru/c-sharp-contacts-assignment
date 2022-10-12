List<Contact> contacts = new List<Contact>();
contacts.Add(new Contact("Sam","347678","sam@gmail.com"));
contacts.Add(new Contact("Tom","345758","tom@gmail.com"));
contacts.Add(new Contact("Zen","764678","zen@gmail.com"));
bool loop=true;





while (loop) {
	Console.WriteLine("1 Display Contact Names");
	Console.WriteLine("2 Search for Contact");
	Console.WriteLine("3 Edit Contact");
	Console.WriteLine("4 New Contact");
    Console.WriteLine("5 Remove Contact");
	Console.WriteLine("6 Exit");
	string selection = Console.ReadLine();


    if (selection == "1"){
        foreach (Contact item in contacts)
        {
            Console.WriteLine(item.Name+" "+item.Phone+" "+item.Email);
        }
    }


    else if (selection == "2"){
        int index=0;
        Console.WriteLine("Please Enter a name to search  ");
        string findname=Console.ReadLine();
        foreach(Contact item1 in contacts){
            if (item1.Name == findname){
                Console.WriteLine(item1.Name+" "+item1.Phone+" "+item1.Email);
                index=-1;
            }
            
        }
        if(index == 0){
             Console.WriteLine("Not Found");
            }


    }

    else if(selection == "3"){
        int index1=-1;
        Console.WriteLine("Please Enter a name to edit ");
        string editname =Console.ReadLine();
        foreach(Contact item2 in contacts){
        if (editname == item2.Name){
            Console.WriteLine("Please Enter a new name");
            string newname=Console.ReadLine();
            Console.WriteLine("Please Enter new email");
            string newemail=Console.ReadLine();
            Console.WriteLine("Please Enter new phone number");
            string newphone=Console.ReadLine();
            item2.Name=newname;
            item2.Email=newemail;
            item2.Phone=newphone;
            Console.WriteLine("Data Changed");
            index1=0;
        }}
        if (index1==-1){
            Console.WriteLine("Name Does not Found");
        }
    }

    else if(selection == "4"){
        Console.WriteLine("Please Enter a new name");
        string nname =Console.ReadLine();
        Console.WriteLine("Please Enter a new email");
        string nemail =Console.ReadLine();
        Console.WriteLine("Please Enter a new phone");
        string nphone =Console.ReadLine();
        contacts.Add(new Contact(nname,nemail,nphone));
        Console.WriteLine("New Contact is added");
    }

    else if (selection == "5"){
        int index2=-1;
        Console.WriteLine("Please Enter a name to remove");
        string removingnname=Console.ReadLine();
        for(int a=0;a<contacts.Count;a++){
            if (contacts[a].Name == removingnname ){
                contacts.RemoveAt(a);
                index2=0;
                Console.WriteLine("Removed");
            } 
        }
        if(index2==-1){
            Console.WriteLine("Name not found");
        }

    }



    else if (selection == "6")
    {
         loop=false;
         Console.WriteLine("Bye");
    }



}









class Contact{
    public string Name { get; set; }
	public string Phone { get; set; }
	public string Email { get; set; }
    
    public Contact(string name,string phone,string email){
        this.Name= name;
        this.Phone=phone;
        this.Email=email;

    }

    
}

