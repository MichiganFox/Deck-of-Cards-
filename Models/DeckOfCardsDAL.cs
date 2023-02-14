using Newtonsoft.Json;
using System.Net;

namespace DeckOfCards.Models
{
    public class DeckOfCardsDAL
    {
        public static CardDeck GetCard(string id)
        {
            //setup
            string url = "https://deckofcardsapi.com/api/deck/xtmuw1u1ag7x/draw/?count=5";

            //request 
            HttpWebRequest request = WebRequest.CreateHttp(url);
            HttpWebResponse response = (HttpWebResponse)request.GetResponse();

            //Convert it to JSON
            StreamReader reader = new StreamReader(response.GetResponseStream());// taking one line of code to being able to read many lines at one time 
            string JSON = reader.ReadToEnd();

            //Converting to C#
            CardDeck result = JsonConvert.DeserializeObject<CardDeck>(JSON);
            return result;

        }
    }
}
