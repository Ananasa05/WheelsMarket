namespace WheelsMarket.wwwroot.js
{
    public class filter
    {
        <script>
        $(document).ready(function () {
            $('#filterForm').submit(function (event) {
                event.preventDefault(); // Prevent normal form submission
                var formData = $(this).serialize(); // Serialize form data

                $.ajax({
                    type: 'POST',
                    url: $(this).attr('action'), // Get form action URL
                    data: formData,
                    success: function (response) {
                        $('#vehicleContainer').html(response); // Update the content of the container with the response
                    },
                    error: function (xhr, status, error) {
                        console.error(xhr.responseText);
                    }
                });
            });
    });
    </script>

    }
}
