using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web;
using task.Models;
using task.repositories;
using task.ViewModels;

namespace task.Services
{
    public class SampleService
    {
        private readonly Repository<ReceivedSamples> _samplerepo = new Repository<ReceivedSamples>();

        public async Task<ReceivedSamples> GetById(int id)
        {
            return await _samplerepo.GetById(id);
        }
        public async Task<IEnumerable<ReceivedSamples>> GetAll()
        {
            return await _samplerepo.GetAll();
        }
        public async Task<int> Add(AddSampleVM sample)
        {
            #region mapping 
            ReceivedSamples newsample = new ReceivedSamples()
            {
                name = sample.name,
                clientId = sample.clientId,
                receivingSideId = sample.receivingSideId,
                describtion = sample.describtion,
                recevingDate = sample.recevingDate,
                numberOfSamples = sample.numberOfSamples,
                attachments = sample.attachments,
                clienAttachments = sample.clienAttachments,
                sampleCost = sample.sampleCost,
                status = sample.status
            };
            #endregion

            return await _samplerepo.add(newsample);
        }
        public async Task Delete(int id)
        {
            await _samplerepo.Delete(id);
        }
      
        public async Task  edit(int id, AddSampleVM newsample)
        {
            #region mapping
            ReceivedSamples oldsample =await _samplerepo.GetById(id);
            if(oldsample != null) { 
            oldsample.name = newsample.name;
            oldsample.numberOfSamples=newsample.numberOfSamples;
            oldsample.recevingDate = newsample.recevingDate;
            oldsample.attachments = newsample.attachments;
            oldsample.clienAttachments = newsample.clienAttachments;
            oldsample.clientId = newsample.clientId;
            oldsample.status = newsample.status;
            oldsample.receivingSideId=newsample.receivingSideId;
                }
            #endregion
            _samplerepo.Update(oldsample);
        }

    }
}