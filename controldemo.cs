using System.Collections.Generic;
using System.Runtime.InteropServices;
using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Mvc;
using dotnetapp.Models;

namespace dotnetapp.Controllers{

public class FeedbackController:Controller{
    public static List<Feedback>feedbacklist=new List<Feedback>();
    public IActionResult Index(){
        return View(feedbacklist);
    }

    [HttpGet]
    public IActionResult Create(){
        return View();
    }

    [HttpPost]
    public IActionResult Create(Feedback feedback){
        feedback.Id=feedbacklist.Count+1;
        feedbacklist.Add(feedback);
        
        return RedirectToAction("Index");
    }



    [HttpGet]
    public IActionResult Edit(){
        return View();
    }
    [HttpPost]
    public IActionResult Edit(Feedback feedback){
        var res=feedbacklist.Find(a=>a.Id==feedback.Id);

        if(res!=null){
            res.StudentName=feedback.StudentName;
            res.Course=feedback.Course;
            res.Feedbacks=feedback.Feedbacks;
            res.Rating=feedback.Rating;
            
        }
        return View(feedback);
    }

    [HttpGet]
    public IActionResult Delete(int id){
        var res=feedbacklist.Find(a=>a.Id==id);

        return View(res);
    }

    [HttpPost, ActionName("DeleteConfirmed")]
    public IActionResult DeleteConfirmed(int id){
        var res=feedbacklist.Find(a=>a.Id==id);

        if(res!=null){
            feedbacklist.Remove(res);
        }
        return RedirectToAction("Index");
    }
}
}
