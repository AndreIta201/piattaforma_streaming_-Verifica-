int contaOre = 0, contaFollower = 0, contaDirette = 0, conta30 = 0, conta1000 = 0, followerMax = 0, spettatoriMax = 0,contaSpettatori=0;
float mediaOre = 0,mediaFollower = 0, conta20=0, mediaSpettatori = 0;
for (int i = 0; i < 12; i++)
{
    Console.WriteLine("Inserire il numero di ore trasmesse del creator: " + (i + 1));
    int ore = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Inserire il numero medio di spettatori del creator: " + (i + 1));
    int spettatori = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Inserire il numero di follower ottenuti del creator: " + (i + 1));
    int follower = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Inserire il numero di dirette effetuate del creator: " + (i + 1));
    int dirette = Convert.ToInt32(Console.ReadLine());
    //contatore
    contaOre += ore;
    contaFollower += follower;
    contaDirette += dirette;

    if (ore >= 30)
    {
        conta30++;
    }
    if (follower >=1000)
    {
        conta1000++;
    }
    //max
    if (i == 0)
    {
        followerMax = i;
    }
    else if (follower > followerMax)
    {
        followerMax = i;
    }
    if (i == 0)
    {
        spettatoriMax = i;
    }
    else if (follower > followerMax)
    {
        spettatoriMax = i;
    }
    //percentuale
    if (ore >= 20)
    {
        conta20++;
    }
    //valutazione
    if (follower >= 2000)
    {
        Console.WriteLine("Creator Top");
    }
    else if (follower >= 1000)
    {
        Console.WriteLine("Creator molto seguito");
    }
    else if (follower >= 500)
    {
        Console.WriteLine("Creator emergente");
    }
    else
    {
        Console.WriteLine("Creator in crescita");
    }

        // spettatori
        contaSpettatori += spettatori;
    
}
Console.WriteLine("Il numero di ore trasmesse totali è: " + contaOre);
Console.WriteLine("Il numero di follower totali è: " + contaFollower);
Console.WriteLine("Il numero di dirette totali è: " + contaDirette);
//media
mediaOre = contaOre / 12f;
Console.WriteLine("la media delle ora totali sono: " + mediaOre);
mediaFollower = contaFollower / 12f;
Console.WriteLine("La media dei follower totali è: " + mediaFollower);
// ore e follower superiori a 30 e 1000
Console.WriteLine("il numero di follower che ha superato le 30 ore di streaming sono: " + conta30);
Console.WriteLine("il numero di follower che ha superato i 1000 follower sono: " + conta1000);
//max
Console.WriteLine("Il numero creator con il numero più alto di follower è: "+ followerMax);
Console.WriteLine("Il numero creator con il numero più alto di spettatori è: " + spettatoriMax);
// percentuale
conta20*=0.12f;
//media spettatori
mediaSpettatori = contaSpettatori / 12f;
if (mediaSpettatori >= 2000)
{
    Console.WriteLine("Periodo eccezionale");
}
else if (mediaSpettatori >= 1000)
{
    Console.WriteLine("Periodo molto positivo");
}
else if (mediaSpettatori >= 500)
{
    Console.WriteLine("Periodo positivo");
}
else
{
    Console.WriteLine("Necessario aumentare il pubblico");
}