using System;
using System.Collections.Generic;
using System.Linq;
using System.Resources;
using System.Runtime.InteropServices;
namespace MilestoneretestpracCollection;

public class Train{
    public int trainId{get;set;}
    public string trainName{get;set;}
    public string source{get;set;}
    public string destination{get;set;}
    public string TrainType{get;set;}
    public int capacity{get;set;}
    public DateTime departureTime{get;set;}
    public Train(){}
    
    public Train(int id, string n, string s, string des, string ty, int cap, DateTime dep){
        trainId=id;
        trainName=n;
        source=s;
        destination=des;
        TrainType=ty;
        capacity=cap;
        departureTime=dep;
    }
	public void DisplayTrainDetails(){
			Console.WriteLine($"TrainId: {trainId}, trainname: {trainName}");
		
}


class Program
{
    static HashSet<Train> trains {get;set;}=new HashSet<Train>();
    static void Main(string[] args)
    {
        Train obj=new Train();
		while(true){

        Console.WriteLine("Menu");
        Console.WriteLine("1. Add train");
        Console.WriteLine("2. Update train");
        Console.WriteLine("3. Search Train by id");
        Console.WriteLine("4. search train by type");
        Console.WriteLine("5. Delete elemet by id");
        Console.WriteLine("6. Delete train by Des");
        Console.WriteLine("7. Display all");
        Console.WriteLine("8. Exit");

        Console.WriteLine("Enter the choice");
        int inp=int.Parse(Console.ReadLine());
        switch(inp){
            case 1:
                Console.Write("Enter Id: ");
                obj.trainId = int.Parse(Console.ReadLine());

                Console.Write("Enter TrainName:");
                obj.trainName=Console.ReadLine();

                Console.Write("Enter Source:");
                obj.source=Console.ReadLine();

                Console.Write("Enter Destination: ");
                obj.destination=Console.ReadLine();

                Console.Write("TrainType: ");
                obj.TrainType=Console.ReadLine();

                Console.Write("Capacity: ");
                obj.capacity=int.Parse(Console.ReadLine());

                Console.Write("DepartureTime: ");
                obj.departureTime=DateTime.Parse(Console.ReadLine());

                AddTrain(obj);
                break;
            
            case 2:
                Console.Write("Enter Id: ");
                obj.trainId = int.Parse(Console.ReadLine());

                Console.Write("Enter TrainName:");
                obj.trainName=Console.ReadLine();

                Console.Write("Enter Source:");
                obj.source=Console.ReadLine();

                Console.Write("Enter Destination: ");
                obj.destination=Console.ReadLine();

                Console.Write("TrainType: ");
                obj.TrainType=Console.ReadLine();

                Console.Write("Capacity: ");
                obj.capacity=int.Parse(Console.ReadLine());

                Console.Write("DepartureTime: ");
                obj.departureTime=DateTime.Parse(Console.ReadLine());

                UpdateTrain(obj.trainId, obj);
                break;
            
            case 3:
                Console.WriteLine("Enter the id");
                int id=int.Parse(Console.ReadLine());
                SearchTrainByID(id);
                break;
            
            case 4:
                Console.WriteLine("Enter the typ");
                string type=Console.ReadLine();
                SearchTrainByType(type);
				break;
            
            case 5:
                Console.WriteLine("enter id:");
                int id1=int.Parse(Console.ReadLine());
                DeleteTrainById(id1);
                break;
            
            case 6:
                Console.WriteLine("Enter the des");
                string des=Console.ReadLine();
                DeleteTrainByDes(des);

                break;
            
            case 7:
                DisplayAllTrains();
                break;

            case 8:
                Console.WriteLine("Exiting...");
                return;
                break;

            default:
                Console.WriteLine("Invalid Choice.");
                break;
        }
		}
        
    }

    public static void AddTrain(Train obj){
        var res=trains.FirstOrDefault(a=>a.trainId==obj.trainId);

        if(res!=null){
            Console.WriteLine("Train with ID already exist.");
        }

        trains.Add(obj);
        Console.WriteLine("Train Added successfully.");
    }

    public static void UpdateTrain(int id, Train obj){
        var res=trains.FirstOrDefault(a=> a.trainId==id);

        if(res==null){
            Console.WriteLine($"Train with ID: {id} not found.");
            return;
        }

        foreach(var i in trains){
            i.trainId=obj.trainId;
            i.trainName=obj.trainName;
            i.source=obj.source;
            i.destination=obj.destination;
            i.TrainType=obj.TrainType;
            i.capacity=obj.capacity;
            i.departureTime=obj.departureTime;
        }
        Console.WriteLine("Details Updated Successfully.");
    }

    public static void SearchTrainByID(int id){
        var res=trains.FirstOrDefault(a=>a.trainId==id);
        if(res!=null){
            res.DisplayTrainDetails();
            return;
        }

        Console.WriteLine($"Train with {id} not found.");
    }

    public static void SearchTrainByType(string type){
        var res=trains.FirstOrDefault(a=> a.TrainType==type);
        if(res!=null){
            res.DisplayTrainDetails();
            return;
        }
        Console.WriteLine($"Train with Type {type} not found.");
    }

    public static void DeleteTrainById(int id){
        var res=trains.FirstOrDefault(a=>a.trainId==id);
        
        if(res!=null){
            trains.Remove(res);
            Console.WriteLine("Deleted Successfully.");
            return;
        }

        Console.WriteLine($"Train with id {id} not found");
    }

    public static void DeleteTrainByDes(string des){
        var res=trains.FirstOrDefault(a=>a.destination==des);
        
        if(res!=null){
            trains.Remove(res);
            Console.WriteLine("Deleted Successfully.");
            return;
        }

        Console.WriteLine($"Train with destination {des} not found");
    }

    public static void DisplayAllTrains(){
        foreach(var i in trains){
            i.DisplayTrainDetails();
        }
    }
}
}
