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

        public async void CreateFlow(string name, string rss, Category category)
        {
            await GetRSSFeed(rss);
            Console.WriteLine(feed.Title.Text);
            string title = feed.Title.Text;
            List<Episode> episodes = new List<Episode>();
            foreach(SyndicationItem item in feed.Items)
            {
                Episode episode = new Episode(item.Title.Text, item.Summary.Text);
                episodes.Add(episode);
            }
            Flow newFlow = new Flow(name, title, category, episodes);
            flowRepository.Insert(newFlow);
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

        //public void UpdateFlowName(int index, string newName)
        //{
        //    Category category = new Category(newName);
        //    categoryRepository.Update(category, index);
        //}
    }
}