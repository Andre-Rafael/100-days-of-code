import java.util.Scanner;

import day_01.CalcAge;

public class App {
    public static void main(String[] args) throws Exception {
        Scanner scan = new Scanner(System.in);
        CalcAge calcAge = new CalcAge();

        System.out.println("Digit the age: ");
        Integer ageNum = scan.nextInt();
        System.out.println(calcAge.calcAge(ageNum) + " days");
        scan.close();
    }
}
