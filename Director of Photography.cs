// Write any using statements here

class Solution {
  
  public int getArtisticPhotographCount(int N, string C, int X, int Y) {
    // Write your code here
    int j =0;
    int numberOfArtisticsPhotos =0;
    
    for(j=0;j<N;j++) 
    {
      if(C[j] == 'A')
      {
        numberOfArtisticsPhotos += findArtisticPhotosForA(j, N, C, X, Y);        
      }      
    }
    return numberOfArtisticsPhotos;
  }
  
  public int findArtisticPhotosForA(int actorIndex, int N, string C, int X, int Y)
  {
    int ptotographerLeft = 0;
    int ptotographerRight = 0;
    int backdropsLeft = 0;
    int backdropsRight = 0;
    
    //Left Window
    for(int i=actorIndex-X;i>=actorIndex-Y && i>=0; i--)
    {
      if(C[i] == 'P') ptotographerLeft++;
      if(C[i] == 'B') backdropsLeft++;
    }
    
    //Right Window
    for(int i=actorIndex+X;i<=actorIndex+Y && i<N; i++)
    {
      if(C[i] == 'P') ptotographerRight++;
      if(C[i] == 'B') backdropsRight++;
    }
    
    return ((ptotographerLeft * backdropsRight) + (backdropsLeft *  ptotographerRight));
  }
}
