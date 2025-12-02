public class DayTwo {
    public static void PartOne(List<string> lines) {
        long total = 0;
        List<string> ranges = [..lines[0].Split(',')];
        foreach (string range in ranges) {
            List<string> parts = [..range.Split('-')];
            for (long i = long.Parse(parts[0]); i <= long.Parse(parts[1]); i++) {
                string s = i.ToString();
                if (s.Length % 2 != 0) {
                    continue;
                }
                if (s[..(s.Length / 2)] == s[(s.Length / 2)..]) {
                    total += i;
                }
            }
        }
        Console.WriteLine(total);
    }
    
    public static void PartTwo(List<string> lines) {
        long total = 0;
        List<string> ranges = [..lines[0].Split(',')];
        foreach (string range in ranges) {
            List<string> parts = [..range.Split('-')];
            for (long i = long.Parse(parts[0]); i <= long.Parse(parts[1]); i++) {
                string s = i.ToString();
                for (int j = 1; j < s.Length; j++) {
                    if (s.Length % j != 0) {
                        continue;
                    }
                    List<string> substrings = [];
                    for (int k = 0; k < s.Length; k += j) {
                        substrings.Add(s.Substring(k, j));
                    }
                    bool allSame = true;
                    for (int k = 1; k < substrings.Count; k++) {
                        if (substrings[k] != substrings[0]) {
                            allSame = false;
                            break;
                        }
                    }
                    if (true == allSame) {
                        total += i;
                        break;
                    }
                }
            }
        }
        Console.WriteLine(total);
    }
}