using InterfacesTask.Domain.Products;

#region Book
var book = new Book("Alice Walker", "The Color Purple", "11222-123-224X");
book.Print();

book.Borrow("Adam");

book.Print();

book.Return();

book.Print();
#endregion

#region DVD
var dvd = new Dvd("Rob Reiner", "Misery", 107);

dvd.Print();

dvd.Borrow("Philip");

dvd.Print();

dvd.Return();

dvd.Print();
#endregion

#region CD

var cd = new Cd("Eminem", "8 Mile", 10);

cd.Print();

cd.Borrow("Frank");

cd.Print();

cd.Return();

cd.Print();
#endregion