using Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Concretes;

public class Car:BaseEntity<int>
{
    public int ModelId { get; set; }
    public int ModelYear { get; set; }
    public string Plate { get; set; }
    public int State { get; set; }
    public double DailyPrice { get; set; }

    public Model Model { get; set; }

    public Car()
    {
        
    }

    public Car(int modelId, int modelYear, string plate, int state, double dailyPrice, Model model)
    {
        ModelId = modelId;
        ModelYear = modelYear;
        Plate = plate;
        State = state;
        DailyPrice = dailyPrice;
        Model = model;
    } c
}
v