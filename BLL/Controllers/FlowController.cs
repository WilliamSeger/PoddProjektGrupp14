using DAL.Repository;
using DAL;
using Models;
using System.ServiceModel.Syndication;

namespace BLL.Controllers
{
    public class FlowController
    {
        IRepository<Flow> flowRepository;
        SyndicationFeed feed;

        public FlowController()
        {
            flowRepository = new FlowRepository();
        }

        public async Task<bool> CreateFlow(string name, string rss, Category category)
        {
            bool isOk = false;
            await GetRSSFeed(rss);
            if (feed == null)
            {
                return isOk;
            }
            string title = feed.Title.Text;
            List<Episode> episodes = new List<Episode>();
            
            foreach(SyndicationItem item in feed.Items)
            {
                if (item.Summary != null)
                {
                    Episode episode = new Episode(item.Title.Text, item.Summary.Text);
                    episodes.Add(episode);
                    isOk = true;
                }
                else
                {
                    Episode episode = new Episode(item.Title.Text);
                    episodes.Add(episode);
                    isOk = true;
                }
            }
            if (isOk)
            {
                Flow newFlow = new Flow(name, title, category, episodes);
                flowRepository.Insert(newFlow);
            }
            return isOk;
        }

        public List<Flow> GetFlows()
        {
            return flowRepository.GetAll();
        }

        public void DeleteFlow(int index)
        {
            flowRepository.Delete(index);
        }

        public async Task GetRSSFeed(string rss)
        {
            Serializer<Flow> flowSerializer = new Serializer<Flow>();
            feed = await flowSerializer.DeserializeRSS(rss);
        }
        public Flow getFlow(String name)
        {
            return flowRepository.GetByName(name);
        }
        public void UpdateFlowName(int index, Flow flow, string newName)
        {
            flow.Name = newName;
            flowRepository.Update(flow, index);
        }
        public void updateFlowCategory(int index, Flow flow, Category category)
        {
            flow.Category = category;
            flowRepository.Update(flow, index);
        }
    }
}
