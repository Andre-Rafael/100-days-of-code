package day_01;

import challengeInterface.Challenge;
import java.util.Scanner;

public class CalcAge implements Challenge {
    
    public int calcAge (Integer age) {
        return age * 365;
    }

    @Override
    public void run(){
        Scanner scan = new Scanner(System.in);
        CalcAge calcAge = new CalcAge();

        System.out.println("Digit the age: ");
        Integer ageNum = scan.nextInt();
        System.out.println(calcAge.calcAge(ageNum) + " days");
        scan.close();
    }
}
