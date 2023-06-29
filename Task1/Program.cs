List<int> ArryaNumber(){
    Console.Write("Inter multiple numbers separated by spase: ");
    string NumbersStr = Console.ReadLine();
    string[] NumberArr = NumbersStr.Split(' ');
    List<int> list = new List<int>();
    foreach(string number in NumberArr){
        int Numeral;  
        if(int.TryParse(number, out Numeral)){
        list.Add(Numeral);
        }
        else {
            Console.WriteLine("Enter correctly");
        }
    } 
    return list; 
}

int GetEvenNums(List<int> list){
    int count = 0;
    for(int i = 0; i < list.Count; i++){
        if(list[i]%2 == 0){
            count += 1;
        }
    }
    return count;
}

List<int> Courage =  ArryaNumber();
int count = GetEvenNums(Courage);

Console.WriteLine($"Even numbers, among the ones you entered {count}");