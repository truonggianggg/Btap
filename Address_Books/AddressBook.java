package Address_Books;

import java.util.HashMap;
import java.util.Map;
import java.util.Scanner;

public class AddressBook {
    public static HashMap<String, Contact> contacts = new HashMap<String, Contact>();

    public static void addContact(Scanner scanner) {
        System.out.print("Nhap ten: ");
        String name = scanner.next();

        System.out.print("Nhap so dien thoai : ");
        String phone = scanner.next();

        Contact contact = new Contact(name, phone);
        contacts.put(name, contact);

        System.out.println("Lien lac da them : " + contact);
    }

    public static void findContact(Scanner scanner) {
        System.out.print("NNhap ten lien lac can tim kiem: ");
        String name = scanner.next();

        if (contacts.containsKey(name)) {
            Contact contact = contacts.get(name);
            System.out.println("lien lac la: " + contact);
        } else {
            System.out.println("Khong tim thay.");
        }
    }

    public static void displayContacts() {
        System.out.println("Tat ca lien lac:");

        for (Map.Entry<String, Contact> contact : contacts.entrySet()) {
            System.out.println(contact.getValue());
        }
    }
}
