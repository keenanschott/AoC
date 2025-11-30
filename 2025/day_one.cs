List<string> lines = new List<string>(File.ReadAllLines("../aoc.in"));

List<int> left = new List<int>();
List<int> right = new List<int>();

foreach (var line in lines) {
    var tester = line.Split(' ', StringSplitOptions.RemoveEmptyEntries).ToList();
    left.Add(int.Parse(tester[0]));
    right.Add(int.Parse(tester[1]));
    Console.WriteLine(line);
}

foreach (var l in left) {
    Console.WriteLine(l);
}
foreach (var r in right) {
    Console.WriteLine(r);
}