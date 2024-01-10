package day_02;

import challengeInterface.Challenge;

public class FindNemo implements Challenge{
    // ! , ? . are always separated from the last word.
    // Nemo will always look like Nemo, and not NeMo or other capital variations.
    // Nemo's, or anything that says Nemo with something behind it, doesn't count as Finding Nemo.
    // If there are multiple Nemo's in the sentence, only return for the first one.

    
    public String findNemo(String phrase){
        String[] words = phrase.split(" ");

        for (int i = 0; i < words.length; i++) {
            if (words[i].equals("Nemo")) {
                return String.format("I found Nemo at %x!", i+1);
            }
        }
        return "I can't find Nemo :(";
    }

    @Override
    public void run() {
        String phrase = "I love Nemo and Nemo loves me !";
        System.out.println(this.findNemo(phrase));
    }
}
