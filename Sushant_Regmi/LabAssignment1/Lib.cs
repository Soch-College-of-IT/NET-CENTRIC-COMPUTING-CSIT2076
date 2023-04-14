using System;

class Lib {
int n, i;
string book, returnBook;
string[] arr = new string[100];

public void AddBook() {
    Console.WriteLine("Enter how many books you want to add");
    n = int.Parse(Console.ReadLine());
    Console.WriteLine("Enter the name of the books you want to add");
    for (i = 0; i < n; i++) {
        arr[i] = Console.ReadLine();
    }
}

public bool IsBookThere() {
    for (i = 0; i < n; i++) {
        if (book.Equals(arr[i])) {
            arr[i] = null;
            return true;
        }
    }
    return false;
}

public void IssueBook() {
    Console.WriteLine("Which book you want to issue?");
    book = Console.ReadLine();
    if (!IsBookThere()) {
        Console.WriteLine("Book Not Found!!");
    } else {
        Console.WriteLine("Book Found!!");
    }
}

public void ShowAvailableBooks() {
    Console.WriteLine("The available books on the library are:");
    foreach (string boo in arr) {
        if (boo == null) {
            continue;
        }
        Console.WriteLine(boo);
    }
}

public void ReturnBooks() {
    Console.WriteLine("Enter the book that you want to return");
    returnBook = Console.ReadLine();
    for (i = 0; i < n; i++) {
        if (arr[i] == null) {
            arr[i] = returnBook;
            break;
        }
    }
}
}

class Library {
static void Main(string[] args) {
Lib obj = new Lib();
obj.AddBook();
obj.IssueBook();
obj.ShowAvailableBooks();
obj.ReturnBooks();
obj.ShowAvailableBooks();
}
}