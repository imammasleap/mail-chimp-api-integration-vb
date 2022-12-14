<nav class="navbar navbar-expand-md navbar-dark fixed-top bg-dark">
    <div class="container">

        <div class="navbar-header ">
            <button class="navbar-toggler" type="button" data-toggle="collapse" data-target="#navbarSupportedContent" aria-controls="navbarSupportedContent" aria-expanded="false" aria-label="Toggle navigation">
                <i class="fas fa-bars"></i>
            </button>
            @Html.ActionLink("MailChimp API", "Index", "Home", New With {.area = ""}, New With {.class = "navbar-brand"})
        </div>


        <button class="navbar-toggler" type="button" data-bs-toggle="collapse" data-bs-target="#navbarNav" aria-controls="navbarNav" aria-expanded="false" aria-label="Toggle navigation">
            <span class="navbar-toggler-icon"></span>
        </button>
        <div class="collapse navbar-collapse  " id="navbarNav">
            <ul class="navbar-nav">

                <li class="nav-item">@Html.ActionLink("Home", "Index", "Home", New With {.area = ""}, New With {.class = "nav-link"})</li>
                <li class="nav-item">@Html.ActionLink("Audiences", "Audiences", "Home", New With {.area = ""}, New With {.class = "nav-link"})</li>
                <li class="nav-item">@Html.ActionLink("Users", "Users", "Home", New With {.area = ""}, New With {.class = "nav-link"})</li>
                <li class="nav-item">@Html.ActionLink("Groups", "Groups", "Home", New With {.area = ""}, New With {.class = "nav-link"})</li>
                <li class="nav-item">@Html.ActionLink("Categories", "Categories", "Home", New With {.area = ""}, New With {.class = "nav-link"})</li>
                <li class="nav-item">@Html.ActionLink("Update Users", "Update", "Home", New With {.area = ""}, New With {.class = "nav-link"})</li>
                <li class="nav-item">@Html.ActionLink("Email", "Email", "Home", New With {.area = ""}, New With {.class = "nav-link"})</li>
            </ul>
        </div>
    </div>

</nav>
