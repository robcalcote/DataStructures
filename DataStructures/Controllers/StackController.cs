using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace DataStructures.Controllers
{
    public class StackController : Controller
    {
        // create static stack structure
        static Stack<string> myStack = new Stack<string>();

        // GET: Stack
        public ActionResult Index()
        {
            // myStack currently has nothing, so it's instantiating ViewBag.MyStack
            ViewBag.MyStack = myStack;

            return View();
        }

        // AddOne Method, will add "New Entry + 'n'" to the stack, and store it in the ViewBag.MyStack
        public ActionResult AddOne()
        {
            myStack.Push("New Entry " + (myStack.Count + 1));

            ViewBag.MyStack = myStack;

            return View("Index");
        }
    }
}