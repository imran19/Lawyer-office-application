﻿using NSI.Repository.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;
using IkarusEntities;
using Microsoft.Extensions.Logging;
using System.Linq;
using Microsoft.EntityFrameworkCore;

namespace NSI.Repository.Repository
{
    public class ConversationsRepository : IConversationsRepository
    {
        private readonly IkarusContext context;
        private readonly ILogger<ConversationsRepository> logger;

        public ConversationsRepository(IkarusContext context, ILogger<ConversationsRepository> logger)
        {
            this.context = context;
            this.logger = logger;
        }

        public bool CheckIFConversationExists(int conversationId)
        {
            try
            {
                return (context.Conversation.Where(x => x.ConversationId == conversationId).FirstOrDefault() != null);
            }
            catch (Exception ex)
            {
                logger.LogError("Something went wrong in ConversationsRepository:GetAllConversations(): " + ex.Message);
                throw new Exception(message: "Error in ConversationsRepository", innerException: ex);
            }
        }

        public IEnumerable<Conversation> GetAllConversations()
        {
            try
            {
                return context.Conversation.Include(x => x.Message)
                                           .Include(x => x.Participant)
                                           .ToList();
            }   
            catch(Exception ex)
            {
                logger.LogError("Something went wrong in ConversationsRepository:GetAllConversations(): " + ex.Message);
                throw new Exception(message: "Error in ConversationsRepository", innerException: ex);
            }
        }

        public IEnumerable<Participant> GetConversationParticipants(int conversationId)
        {
            try
            {
                return context.Participant.Where(x => x.ConversationId == conversationId).ToList();
            }
            catch (Exception ex)
            {
                logger.LogError("Something went wrong in ConversationsRepository:GetConversationParticipants: " + ex.Message);
                throw new Exception(message: "Error in ConversationsRepository:GetConversationParticipants", innerException: ex);
            }
        }

        public IEnumerable<Message> GetMessagesFromConversation(int conversationId)
        {
            try
            {
                return context.Message.Where(x => x.ConversationId == conversationId).ToList();
            }
            catch (Exception ex)
            {
                logger.LogError("Something went wrong in ConversationsRepository:GetMessagesFromConversation(): " + ex.Message);
                throw new Exception(message: "Error in ConversationsRepository", innerException: ex);
            }
        }
    }
}
