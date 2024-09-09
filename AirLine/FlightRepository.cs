using System.Data.SqlClient;
using System.Data;
using AirLine;
using Flight;


namespace AirLine
{

public class FlightRepository
{
    private readonly SqlConnection _connection;

    public FlightRepository(SqlConnection connection)
    {
        _connection = connection;
    }

    public void AddFlight(Flight flight)
    {
        using (SqlCommand command = new SqlCommand("INSERT INTO Flights (FlightNumber, DepartureDate, DepartureAirport, ArrivalDate, ArrivalAirport, Price, Status) VALUES (@FlightNumber, @DepartureDate, @DepartureAirport, @ArrivalDate, @ArrivalAirport, @Price, @Status)", _connection))
        {
            command.Parameters.AddWithValue("@FlightNumber", flight.FlightNumber);
            command.Parameters.AddWithValue("@DepartureDate", flight.DepartureDate);
            command.Parameters.AddWithValue("@DepartureAirport", flight.DepartureAirport);
            command.Parameters.AddWithValue("@ArrivalDate", flight.ArrivalDate);
            command.Parameters.AddWithValue("@ArrivalAirport", flight.ArrivalAirport);
            command.Parameters.AddWithValue("@Price", flight.Price);
            command.Parameters.AddWithValue("@Status", flight.Status);
            command.ExecuteNonQuery();
        }
    }

    public void UpdateFlight(Flight flight)
    {
        using (SqlCommand command = new SqlCommand("UPDATE Flights SET FlightNumber = @FlightNumber, DepartureDate = @DepartureDate, DepartureAirport = @DepartureAirport, ArrivalDate = @ArrivalDate, ArrivalAirport = @ArrivalAirport, Price = @Price, Status = @Status WHERE Id = @Id", _connection))
        {
            command.Parameters.AddWithValue("@Id", flight.Id);
            command.Parameters.AddWithValue("@FlightNumber", flight.FlightNumber);
            command.Parameters.AddWithValue("@DepartureDate", flight.DepartureDate);
            command.Parameters.AddWithValue("@DepartureAirport", flight.DepartureAirport);
            command.Parameters.AddWithValue("@ArrivalDate", flight.ArrivalDate);
            command.Parameters.AddWithValue("@ArrivalAirport", flight.ArrivalAirport);
            command.Parameters.AddWithValue("@Price", flight.Price);
            command.Parameters.AddWithValue("@Status", flight.Status);
            command.ExecuteNonQuery();
        }
    }

    public void DeleteFlight(int id)
    {
        using (SqlCommand command = new SqlCommand("DELETE FROM Flights WHERE Id = @Id", _connection))
        {
            command.Parameters.AddWithValue("@Id", id);
            command.ExecuteNonQuery();
        }
    }

    public DataTable GetFlights()
    {
        using (SqlCommand command = new SqlCommand("SELECT * FROM Flights", _connection))
        {
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            DataTable table = new DataTable();
            adapter.Fill(table);
            return table;
        }
    }
}
}