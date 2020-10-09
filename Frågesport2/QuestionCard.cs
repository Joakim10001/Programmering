using System;
namespace Frågesport
{
    public class QuestionCard
    {
      private string question;
      private string answer;

      public QuestionCard(string q, string ans)
      {
          question = q;
          answer = ans;
      }

      public string GetQuestion()
      {
          return question;
      }

      public bool IsCorrect(string guess)
      {
          return answer == guess;
      }
    }
    


    
}