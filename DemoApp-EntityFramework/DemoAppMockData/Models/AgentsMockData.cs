using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DemoAppMockData.Models
{
    public class AgentsMockData : IAgents
    {
        public IEnumerable<Agents> AllAgents =>
            new List<Agents>
            {
                new Agents {Id = 1, Name="Jessie Culbert Boucher",ShortDescription="Lorem Ipsum", LongDescription="Lorem IpsumLorem IpsumLorem IpsumLorem Ipsum", ContactNumber = "(206) 866 2371" , NumberOfDeals="53", ImageUrl="https://realestateblobstorgae.blob.core.windows.net/agents/JessieCulbertBoucher.JPG", ImageThumbnailUrl="https://realestateblobstorgae.blob.core.windows.net/agents/JessieCulbertBoucher.JPG", NumberOfReviews=114, Rating=4 },
                new Agents {Id = 2, Name="Francis Quedado",ShortDescription="Lorem Ipsum", LongDescription="Lorem IpsumLorem IpsumLorem IpsumLorem Ipsum", ContactNumber = "(206) 429 4360" , NumberOfDeals="49", ImageUrl="https://realestateblobstorgae.blob.core.windows.net/agents/FrancisQuedado.JPG", ImageThumbnailUrl="https://realestateblobstorgae.blob.core.windows.net/agents/FrancisQuedado.JPG", NumberOfReviews=90, Rating=5 },
                new Agents {Id = 3, Name="Tara Townsand",ShortDescription="Lorem Ipsum", LongDescription="Lorem IpsumLorem IpsumLorem IpsumLorem Ipsum", ContactNumber = "(206) 539 0528" , NumberOfDeals="29", ImageUrl="https://realestateblobstorgae.blob.core.windows.net/agents/TaraTownsand.JPG", ImageThumbnailUrl="https://realestateblobstorgae.blob.core.windows.net/agents/TaraTownsand.JPG", NumberOfReviews=138, Rating=3 },
                new Agents {Id = 4, Name="Jessie Culbert Boucher",ShortDescription="Lorem Ipsum", LongDescription="Lorem IpsumLorem IpsumLorem IpsumLorem Ipsum", ContactNumber = "(206) 866 2371" , NumberOfDeals="53", ImageUrl="https://realestateblobstorgae.blob.core.windows.net/agents/JessieCulbertBoucher.JPG", ImageThumbnailUrl="https://realestateblobstorgae.blob.core.windows.net/agents/JessieCulbertBoucher.JPG", NumberOfReviews=114, Rating=4 },
                new Agents {Id = 5, Name="Jessie Culbert Boucher",ShortDescription="Lorem Ipsum", LongDescription="Lorem IpsumLorem IpsumLorem IpsumLorem Ipsum", ContactNumber = "(206) 866 2371" , NumberOfDeals="53", ImageUrl="https://realestateblobstorgae.blob.core.windows.net/agents/JessieCulbertBoucher.JPG", ImageThumbnailUrl="https://realestateblobstorgae.blob.core.windows.net/agents/JessieCulbertBoucher.JPG", NumberOfReviews=114, Rating=4 },
                new Agents {Id = 6, Name="Francis Quedado",ShortDescription="Lorem Ipsum", LongDescription="Lorem IpsumLorem IpsumLorem IpsumLorem Ipsum", ContactNumber = "(206) 429 4360" , NumberOfDeals="49", ImageUrl="https://realestateblobstorgae.blob.core.windows.net/agents/FrancisQuedado.JPG", ImageThumbnailUrl="https://realestateblobstorgae.blob.core.windows.net/agents/FrancisQuedado.JPG", NumberOfReviews=90, Rating=5 },
                new Agents {Id = 7, Name="Tara Townsand",ShortDescription="Lorem Ipsum", LongDescription="Lorem IpsumLorem IpsumLorem IpsumLorem Ipsum", ContactNumber = "(206) 539 0528" , NumberOfDeals="29", ImageUrl="https://realestateblobstorgae.blob.core.windows.net/agents/TaraTownsand.JPG", ImageThumbnailUrl="https://realestateblobstorgae.blob.core.windows.net/agents/TaraTownsand.JPG", NumberOfReviews=138, Rating=3 },
                new Agents {Id = 8, Name="Jessie Culbert Boucher",ShortDescription="Lorem Ipsum", LongDescription="Lorem IpsumLorem IpsumLorem IpsumLorem Ipsum", ContactNumber = "(206) 866 2371" , NumberOfDeals="53", ImageUrl="https://realestateblobstorgae.blob.core.windows.net/agents/JessieCulbertBoucher.JPG", ImageThumbnailUrl="https://realestateblobstorgae.blob.core.windows.net/agents/JessieCulbertBoucher.JPG", NumberOfReviews=114, Rating=4 }

            };

        public Agents GetAgentById(int agentId)
        {
            return AllAgents.FirstOrDefault(agent => agent.Id == agentId);
        }
    }
}
