public class DayOne {
    public static void PartOne(List<string> lines) {
        int dial = 50;
        int total = 0;
        foreach (string line in lines) {
            int val = int.Parse(line[1..]) % 100;
            if (line[0] == 'L') {
                dial -= val;
            } else {
                dial += val;
            }
            if (dial < 0) {
                dial += 100;
            } else if (dial > 99) {
                dial -= 100;
            } 
            if (dial == 0) {
                total += 1;
            }
        }
        Console.WriteLine(total);
    }
    
    public static void PartTwo(List<string> lines) {
        int dial = 50;
        int total = 0;
        foreach (string line in lines) {
            int val = int.Parse(line[1..]) % 100;
            int previousDial = dial;
            total += int.Parse(line[1..]) / 100;
            if (line[0] == 'L') {
                dial -= val;
            } else {
                dial += val;
            }
            if (dial < 0) {
                dial += 100;
                if (previousDial != 0) {
                    total += 1;
                }
            } else if (dial > 99) {
                dial -= 100;
                if (previousDial != 0) {
                    total += 1;
                }
            } else if (dial == 0) {
                total += 1;
            }
        }
        Console.WriteLine(total);
    }
}