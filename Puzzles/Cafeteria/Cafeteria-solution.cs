// Write any using statements here

class Solution {
  
  public long getMaxAdditionalDinersCount(long N, long K, int M, long[] S) {
    long[] occupiedSeats= new long[N];
    
    for(long i=0; i<M ; i++) 
    {
      if(S[i] > 0)
        occupiedSeats[S[i]-1] = 1;
    }
    
  long additionalSeats =0;
    for(long i=0; i<N;i++) 
    {
      bool seatOccupied=false;
      for(long r=i;r<=i+K && r<N;r++)
      {
        if(occupiedSeats[r]==1) 
        {
          seatOccupied=true;
          i=r+K;
          break;
        }
      }
      if(!seatOccupied && i<N) 
      {
        occupiedSeats[i]=1; 
        i=i+K;
        additionalSeats++;        
      }      
    }
    
    return additionalSeats;
  }
  
}
