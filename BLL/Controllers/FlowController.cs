﻿using DAL.Repository;
using DAL;
using Models;
using System.ServiceModel.Syndication;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
            await GetRSSFeed(rss);
            string title = feed.Title.Text;
            List<Episode> episodes = new List<Episode>();
            bool isOk = true;
            foreach(SyndicationItem item in feed.Items)
            {
                if (item.Summary != null)
                {
                    Episode episode = new Episode(item.Title.Text, item.Summary.Text);
                    episodes.Add(episode);
                }
                else
                {
                    isOk = false; break;
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
