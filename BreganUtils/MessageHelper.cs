﻿using BreganUtils.Dtos;
using Newtonsoft.Json;
using RestSharp;

namespace BreganUtils
{
    public class MessageHelper
    {
#if DEBUG
        private static readonly string _apiKey = "";
#else
        private static readonly string _apiKey = "";
#endif

        public static bool SendEmail(string toEmailAddress, string toEmailAddressName, string fromEmailAddress, string fromEmailAddressName, object emailContent, string templateId)
        {
            try
            {
                var client = new RestClient("https://messagingapi.bregan.me");
                var request = new RestRequest("/api/Send/ScheduleEmail", Method.Post);
                request.AddHeader("Authorization", _apiKey);

                request.AddBody(new ScheduleEmailDto
                {
                    Content = JsonConvert.SerializeObject(emailContent),
                    FromEmailAddress = fromEmailAddress,
                    FromEmailAddressName = fromEmailAddressName,
                    TemplateId = templateId,
                    ToEmailAddress = toEmailAddress,
                    ToEmailAddressName = toEmailAddressName
                });

                client.Post(request);

                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public static bool SendTextMessage(int chatId, string messageContent)
        {
            try
            {
                var client = new RestClient("https://messagingapi.bregan.me");
                var request = new RestRequest("/api/Send/ScheduleText", Method.Post);
                request.AddHeader("Authorization", _apiKey);

                request.AddBody(new ScheduleTextDto
                {
                    ChatId = chatId,
                    Content = messageContent
                });

                client.Post(request);

                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }
    }
}