using HBSISLibraryWeb.HBSISLibraryServiceReference;
using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Web;

namespace HBSISLibraryWeb.Util
{
    public static class ServerReference
    {
        private struct DisposableCommunicationObjectToken : IDisposable
        {
            private readonly HBSISLibraryServiceClient client;

            internal DisposableCommunicationObjectToken(HBSISLibraryServiceClient obj)
            {
                this.client = obj;
            }

            public void Dispose()
            {
                if (client == null)
                {
                    throw new InvalidOperationException(
                        "The DisposableCommunicationObjectToken structure " +
                        "was created with the default constructor.");
                }

                try
                {
                    client.Close();
                }
                catch (CommunicationException)
                {
                    // Abort if there is a communication exception.
                    client.Abort();
                }
                catch (TimeoutException)
                {
                    // Abort if there is a timeout exception.
                    client.Abort();
                }
                catch (Exception)
                {
                    // Abort in the face of any other exception.
                    client.Abort();

                    // Rethrow.
                    throw;
                }
            }
        }

        public static IDisposable AsDisposable(this HBSISLibraryServiceClient obj)
        {
            return new DisposableCommunicationObjectToken(obj);
        }
    }
}