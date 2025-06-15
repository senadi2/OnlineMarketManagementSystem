using System.Collections.Generic;
using OnlineMarketPLace.models;

namespace OnlineMarketPLace.services
{
    public class DisputeService
    {
        private static List<Dispute> _disputes = new List<Dispute>
        {
            new Dispute("D001", "O1001", "john_doe", "Item not delivered", "Open", "Awaiting seller response"),
            new Dispute("D002", "O1002", "jane_smith", "Wrong item received", "Open", "Investigation ongoing"),
            new Dispute("D003", "O1003", "mike2025", "Payment issue", "Closed", "Refund issued")
        };

        public List<Dispute> GetAllOpenDisputes()
        {
            return _disputes.FindAll(d => d.Status == "Open");
        }

        public List<Dispute> GetAllDisputes()
        {
            return _disputes;
        }
    }
}
