package Address_Books;

import java.util.Scanner;

import static Address_Books.AddressBook.*;

public class Main {
    public static void main(String[] args) {
        Scanner scanner = new Scanner(System.in);
        int choice;
        do {
            System.out.println("Moi ban nhap lua chon:");
            System.out.println("1. Them lien lac moi");
            System.out.println("2. Tim lien lac bang ten");
            System.out.println("3. Hien thi tat ca");
            System.out.println("4. Thoat");

            System.out.print("Nhap lua chon: ");
            choice = scanner.nextInt();

            switch (choice) {
                case 1:
                    addContact(scanner);
                    break;
                case 2:
                    findContact(scanner);
                    break;
                case 3:
                    displayContacts();
                    break;
                case 4:
                    System.out.println("Thoat so lien lac.");
                    break;
                default:
                    System.out.println("Lua chon khong hop le,Thu lai.");
                    break;
            }
        } while (choice != 4);

        scanner.close();
    }
}