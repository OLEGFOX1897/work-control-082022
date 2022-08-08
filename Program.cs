// Контрольная работа 082022 

string [] arrayStart=new string [] {"columb","-)","turist", "try hard","try", "WWW"}; 
string [] arrayFinish=new string [arrayStart.Length]; 
int indTask=0; 
for (int i = 0; i < arrayStart.Length; i++) 
{ 
    if (arrayStart[i].Length<=3) 
    { 
        arrayFinish[indTask]=arrayStart[i]; 
        indTask++; 
    } 
} 
void ShowArray (string [] array) 
{ 
    Console.Write("["); 
    for (int i = 0; i < array.Length; i++) 
    { 
        if (array[i]!=null) 
        { 
            if (i==0) Console.Write($"''{array[i]}''"); 
            else Console.Write($", ''{array[i]}''"); 
        } 
    } 
    Console.Write("]"); 
} 
ShowArray(arrayStart); 
Console.Write(" - > "); 
ShowArray(arrayFinish); 
