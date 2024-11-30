document.addEventListener("DOMContentLoaded", () => {
    const startDate = flatpickr("#start-date", {
        dateFormat: "Y-m-d",
        onChange: (selectedDates, dateStr) => {
            endDate.set("minDate", dateStr);
        },
    });

    const endDate = flatpickr("#end-date", {
        dateFormat: "Y-m-d",
        onChange: (selectedDates, dateStr) => {
            startDate.set("maxDate", dateStr);
        },
    });
});


document.addEventListener('DOMContentLoaded', function () {
    flatpickr("#tanggalLahir", {
        dateFormat: "Y-m-d",
        defaultDate: "2024-11-18"
    });
});


flatpickr("#datepicker", {
    dateFormat: "Y-m-d",
    minDate: "today",
    maxDate: "2024-12-31",
    locale: "id",
});
