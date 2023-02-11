// See https://aka.ms/new-console-template for more information
int szam=0;
int N; 
int max_táv=0;
int kezdo_index=-1;
int vegso_index=-1;
int nincs = -1;
Console.WriteLine("Kérem a sorozat hosszát:");
N=Convert.ToInt32(Console.ReadLine());

int[] array =new int[N];
for (int i = 0; i < N; i++)
{
    szam=Convert.ToInt32(Console.ReadLine());
    array[i]=szam;
}



for (int i = 0; i <N; i++)
{
    for (int j = 0; j < N-i; j++)
    {
        if (array[i] > array[N - i-1])
        {
            kezdo_index = i;
            vegso_index = N-i+1;
        }
    }
    if (kezdo_index>-1 && vegso_index > -1 && vegso_index-kezdo_index>max_táv)
    {
        max_táv = vegso_index - kezdo_index;
    }

}
    
Console.Write(kezdo_index);
Console.Write(vegso_index);