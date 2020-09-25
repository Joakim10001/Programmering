using System;
using System.Collections.Generic;
using System.Diagnostics;

namespace Frågesport
{
     class Program
    {
        static void Main(string[] args)
        {   
            List<QuestionCard>minlista;
            minlista = new List<QuestionCard>();
            QuestionCard card;
            card = new QuestionCard();
            card.question = "Vad heter jag?";
            card.answer = "joakim";
            minlista.Add(card);
            QuestionCard card1;
            card1 = new QuestionCard();
            card1.question = "hur gammal är jag?";
            card1.answer = "19";
            minlista.Add(card1);
            QuestionCard card2;
            card2 = new QuestionCard();
            card2.question = "svergies huvudstad?";
            card2.answer = "stockholm";
            minlista.Add(card2);

            for(int x = 0; x < minlista.Count; x++)
            {
                Console.WriteLine(minlista[x].question);
                string answer;
                answer = Console.ReadLine();
                if(answer == minlista[x].answer)
                {
                    Console.WriteLine("Rätt");
                }
                else
                {
                    Console.WriteLine("Fel");
                }

            }
            

            


            

            

        }

        static void testmetod1()
        {
             List<string>minLista1;
            minLista1 = new List<string>();
            minLista1.Add("vad heter jag?");
            minLista1.Add("vad är sveriges huvudstad?");
            minLista1.Add("hur gammal är jag?");

            

            List<string>minLista;
            minLista = new List<string>();
            minLista.Add("joakim");
            minLista.Add("stockholm");
            minLista.Add("20");

          

            

           

            for(int i = 0; i < 3; i = i + 1)
            {
                Console.WriteLine(minLista1[i]);
                string svar2;
                svar2 = Console.ReadLine();
                if(svar2 == minLista[i])
                {
                    Console.WriteLine("rätt");
                    svar2 = Console.ReadLine();
                }  
                else
                {
                    Console.WriteLine("fel");
                }
        }

        static void nummerfyra()
        {
             List<QuestionCard>minlista;
            minlista = new List<QuestionCard>();
            QuestionCard card;
            card = new QuestionCard();
            card.question = "Vad heter jag?";
            card.answer = "joakim";
            minlista.Add(card);
            QuestionCard card1;
            card1 = new QuestionCard();
            card1.question = "hur gammal är jag?";
            card1.answer = "19";
            minlista.Add(card1);
            QuestionCard card2;
            card2 = new QuestionCard();
            card2.question = "svergies huvudstad?";
            card2.answer = "stockholm";
            minlista.Add(card2);

            for(int x = 0; x < minlista.Count; x++)
            {
                Console.WriteLine(minlista[x].question);
                string answer;
                answer = Console.ReadLine();
                if(answer == minlista[x].answer)
                {
                    Console.WriteLine("Rätt");
                }
                else
                {
                    Console.WriteLine("Fel");
                }
        }




        
        
            
        
    }
}

    }


   
   

 
    
