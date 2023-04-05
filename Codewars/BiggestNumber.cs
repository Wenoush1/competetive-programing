/*
Create a function that takes a positive integer and returns the biggest number that can be formed by rearranging its digits. For example:

     12 ==> 21
    513 ==> 531
    2017 ==> 7210

If the digits can't be rearranged to form a bigger number, return -1 (or nil in Swift, None in Rust):

    9 ==> -1
    111 ==> -1
    531 ==> -1
    */

public static long biggest(long n)
    {
      long final;
      string helper = n.ToString();
      helper = (String.Concat(helper.OrderBy(c=>c)));
      helper = String.Concat(helper.Reverse());
      final=Convert.ToInt64(helper);
      if (final == n) 
      {
        return -1;
      }

      return final;
    }