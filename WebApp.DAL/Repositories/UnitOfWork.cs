using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebApp.DAL.EF;

namespace WebApp.DAL.Repositories
{
   public class UnitOfWork : IDisposable
    {
        private ApplicationContext context;
        private UserRepository userRepository;
        private PhoneRepository phoneRepository;
        private MessageRepository messageRepository;

        public UnitOfWork(string connectionString)
        {
            context = new ApplicationContext(connectionString);
        }

        public UserRepository UserRepository
        {
            get
            {
                if (userRepository == null)
                {
                    userRepository = new UserRepository(new UserStore<User>(context), context);
                }
                return userRepository;
            }
        }

        public PhoneRepository PhoneRepository
        {
            get
            {
                if (phoneRepository == null)
                {
                    phoneRepository = new PhoneRepository(context);
                }
                return phoneRepository;
            }
        }

        public MessageRepository MessageRepository
        {
            get
            {
                if (messageRepository == null)
                {
                    messageRepository = new MessageRepository(context);
                }
                return messageRepository;
            }
        }

        public void Save()
        {
            context.SaveChanges();
        }

        private bool disposed = false;

        protected virtual void Dispose(bool disposing)
        {
            if (!disposed)
            {
                if (disposing)
                {
                    context.Dispose();
                }
            }
            disposed = true;
        }

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }

    }
}
