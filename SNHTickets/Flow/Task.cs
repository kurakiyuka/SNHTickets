using System;

namespace SNHTickets.Flow
{
    public class Task
    {
        public String id { get; set; }
        public Int32 model { get; set; }
        public Int32 accounts_num { get; set; }
        public Task(String id, Int32 model, Int32 accouts_num)
        {
            this.id = id;
            this.model = model;
            this.accounts_num = accouts_num;
        }
    }
}
