using Microsoft.AspNetCore.Components;

namespace GlobalShared.Services.StaticServices
{
    public class SVGService
    {
        #region Utilities
        public static RenderFragment CrossIcon(int w, int h)
        {
            return (builder) =>
            {
                builder.AddMarkupContent(0, string.Format(@"
       	            <svg fill=""currentcolor"" width=""{0}"" height=""{1}"" viewBox=""0 0 32 32""><g id=""SVGRepo_bgCarrier"" stroke-width=""0""></g><g id=""SVGRepo_tracerCarrier"" stroke-linecap=""round"" stroke-linejoin=""round""></g><g id=""SVGRepo_iconCarrier""> <path d=""M18.8,16l5.5-5.5c0.8-0.8,0.8-2,0-2.8l0,0C24,7.3,23.5,7,23,7c-0.5,0-1,0.2-1.4,0.6L16,13.2l-5.5-5.5 c-0.8-0.8-2.1-0.8-2.8,0C7.3,8,7,8.5,7,9.1s0.2,1,0.6,1.4l5.5,5.5l-5.5,5.5C7.3,21.9,7,22.4,7,23c0,0.5,0.2,1,0.6,1.4 C8,24.8,8.5,25,9,25c0.5,0,1-0.2,1.4-0.6l5.5-5.5l5.5,5.5c0.8,0.8,2.1,0.8,2.8,0c0.8-0.8,0.8-2.1,0-2.8L18.8,16z""></path> </g>
                    </svg>
                ", w, h));
            };
        }

        public static RenderFragment PlusIcon(int w, int h)
        {
            return (builder) =>
            {
                builder.AddMarkupContent(0, string.Format(@"
       	            <svg width=""{0}"" height=""{1}"" viewBox=""0 0 24 24"" fill=""none"">
                        <g id=""SVGRepo_bgCarrier"" stroke-width=""0""/>
                        <g id=""SVGRepo_tracerCarrier"" stroke-linecap=""round"" stroke-linejoin=""round""/>
                        <g id=""SVGRepo_iconCarrier""> <path d=""M12.75 11.25V5C12.75 4.80109 12.671 4.61032 12.5303 4.46967C12.3897 4.32902 12.1989 4.25 12 4.25C11.8011 4.25 11.6103 4.32902 11.4697 4.46967C11.329 4.61032 11.25 4.80109 11.25 5V11.25H5C4.80109 11.25 4.61032 11.329 4.46967 11.4697C4.32902 11.6103 4.25 11.8011 4.25 12C4.25 12.1989 4.32902 12.3897 4.46967 12.5303C4.61032 12.671 4.80109 12.75 5 12.75H11.25V19C11.2526 19.1981 11.3324 19.3874 11.4725 19.5275C11.6126 19.6676 11.8019 19.7474 12 19.75C12.1989 19.75 12.3897 19.671 12.5303 19.5303C12.671 19.3897 12.75 19.1989 12.75 19V12.75H19C19.1989 12.75 19.3897 12.671 19.5303 12.5303C19.671 12.3897 19.75 12.1989 19.75 12C19.7474 11.8019 19.6676 11.6126 19.5275 11.4725C19.3874 11.3324 19.1981 11.2526 19 11.25H12.75Z"" fill=""currentcolor""/> </g>
                     </svg>
                ", w, h));
            };
        }

        public static RenderFragment HeartUnfill(int w, int h)
        {
            return (builder) =>
            {
                builder.AddMarkupContent(0, string.Format(@"
       	            <svg width=""{0}"" height=""{1}"" viewBox=""0 0 24 24"" fill=""none""><g id=""SVGRepo_bgCarrier"" stroke-width=""0""></g><g id=""SVGRepo_tracerCarrier"" stroke-linecap=""round"" stroke-linejoin=""round""></g><g id=""SVGRepo_iconCarrier""> <path fill-rule=""evenodd"" clip-rule=""evenodd"" d=""M1 8.5C1 5.21475 3.31333 2 7 2C8.70883 2 9.92877 2.48125 10.8649 3.2079C11.3091 3.55266 11.6802 3.94929 11.9974 4.33639C12.311 3.95011 12.6785 3.55357 13.1186 3.20977C14.0531 2.47979 15.275 2 17 2C20.7289 2 23 5.22013 23 8.5C23 11.8412 21.3259 14.6994 19.2285 16.9297C17.1279 19.1634 14.523 20.8565 12.4472 21.8944C12.1657 22.0352 11.8343 22.0352 11.5528 21.8944C9.47698 20.8565 6.8721 19.1634 4.77151 16.9297C2.67415 14.6994 1 11.8412 1 8.5ZM7 4C4.68667 4 3 6.02986 3 8.5C3 11.1445 4.32585 13.5363 6.22849 15.5596C7.9833 17.4256 10.1612 18.9027 12 19.8754C13.8388 18.9027 16.0167 17.4256 17.7715 15.5596C19.6741 13.5363 21 11.1445 21 8.5C21 6.02448 19.3463 4 17 4C15.6874 4 14.907 4.35067 14.3497 4.78592C13.8333 5.18934 13.4736 5.68102 13.045 6.26703C12.9669 6.37374 12.8866 6.48357 12.8026 6.59656C12.6139 6.85039 12.3163 7 12 7C11.6837 7 11.3861 6.85039 11.1974 6.59656C11.1256 6.49997 11.0562 6.4055 10.9884 6.31318C10.5465 5.71179 10.1717 5.20159 9.63856 4.78779C9.07355 4.34922 8.29117 4 7 4Z"" fill=""currentcolor""></path> </g></svg>
                ", w, h));
            };
        }
        public static RenderFragment HeartFill(int w, int h)
        {
            return (builder) =>
            {
                builder.AddMarkupContent(0, string.Format(@"
       	            <svg fill=""currentcolor"" width=""{0}"" height=""{1}"" viewBox=""0 0 64 64"" version=""1.1"" xml:space=""preserve"" style=""fill-rule:evenodd;clip-rule:evenodd;stroke-linejoin:round;stroke-miterlimit:2;""><g id=""SVGRepo_bgCarrier"" stroke-width=""0""></g><g id=""SVGRepo_tracerCarrier"" stroke-linecap=""round"" stroke-linejoin=""round""></g><g id=""SVGRepo_iconCarrier""> <rect id=""Icons"" x=""-64"" y=""-256"" width=""1280"" height=""800"" style=""fill:none;""></rect> <g id=""Icons1"" serif:id=""Icons""> <g id=""Strike""> </g> <g id=""H1""> </g> <g id=""H2""> </g> <g id=""H3""> </g> <g id=""list-ul""> </g> <g id=""hamburger-1""> </g> <g id=""hamburger-2""> </g> <g id=""list-ol""> </g> <g id=""list-task""> </g> <g id=""trash""> </g> <g id=""vertical-menu""> </g> <g id=""horizontal-menu""> </g> <g id=""sidebar-2""> </g> <g id=""Pen""> </g> <g id=""Pen1"" serif:id=""Pen""> </g> <g id=""clock""> </g> <g id=""external-link""> </g> <g id=""hr""> </g> <g id=""info""> </g> <g id=""warning""> </g> <g id=""plus-circle""> </g> <g id=""minus-circle""> </g> <g id=""vue""> </g> <g id=""cog""> </g> <g id=""logo""> </g> <path d=""M43.046,9.05c5.137,0.117 9.856,3.451 11.782,8.485c2.392,6.249 0.678,13.452 -2.495,19.624c-3.792,7.375 -10.79,12.703 -17.966,17.288c0,0 -2.796,1.351 -5.516,-0.403c-9.246,-6.021 -17.877,-13.963 -20.318,-24.82c-1.857,-8.258 1.161,-18.596 10.582,-20.034c4.72,-0.721 11.109,2.766 12.808,5.869c1.657,-3.095 6.565,-5.884 10.694,-6.008c0.215,-0.002 0.214,-0.003 0.429,-0.001Z"" style=""fill-rule:nonzero;""></path> <g id=""radio-check""> </g> <g id=""eye-slash""> </g> <g id=""eye""> </g> <g id=""toggle-off""> </g> <g id=""shredder""> </g> <g id=""spinner--loading--dots-"" serif:id=""spinner [loading, dots]""> </g> <g id=""react""> </g> <g id=""check-selected""> </g> <g id=""turn-off""> </g> <g id=""code-block""> </g> <g id=""user""> </g> <g id=""coffee-bean""> </g> <g id=""coffee-beans""> <g id=""coffee-bean1"" serif:id=""coffee-bean""> </g> </g> <g id=""coffee-bean-filled""> </g> <g id=""coffee-beans-filled""> <g id=""coffee-bean2"" serif:id=""coffee-bean""> </g> </g> <g id=""clipboard""> </g> <g id=""clipboard-paste""> </g> <g id=""clipboard-copy""> </g> <g id=""Layer1""> </g> </g> </g></svg>
                ", w, h));
            };
        }
        public static RenderFragment CarvonDown(int w, int h)
        {
            return (builder) =>
            {
                builder.AddMarkupContent(0, string.Format(@"
       	            <svg fill=""currentcolor"" width=""{0}"" height=""{1}"" viewBox=""0 0 32 32"" version=""1.1"" ><g id=""SVGRepo_bgCarrier"" stroke-width=""0""></g><g id=""SVGRepo_tracerCarrier"" stroke-linecap=""round"" stroke-linejoin=""round""></g><g id=""SVGRepo_iconCarrier""> <path d=""M0.256 8.606c0-0.269 0.106-0.544 0.313-0.75 0.412-0.412 1.087-0.412 1.5 0l14.119 14.119 13.913-13.912c0.413-0.412 1.087-0.412 1.5 0s0.413 1.088 0 1.5l-14.663 14.669c-0.413 0.413-1.088 0.413-1.5 0l-14.869-14.869c-0.213-0.213-0.313-0.481-0.313-0.756z""></path> </g></svg>
                ", w, h));
            };
        }
        public static RenderFragment ArrowBackIcon(int w, int h)
        {
            return (builder) =>
            {
                builder.AddMarkupContent(0, string.Format(@"
       	            <svg width=""{0}"" height=""{1}"" viewBox=""0 0 24 24"" fill=""none"">
                        <g id=""SVGRepo_bgCarrier"" stroke-width=""0""></g><g id=""SVGRepo_tracerCarrier"" stroke-linecap=""round"" stroke-linejoin=""round""></g>
                        <g id=""SVGRepo_iconCarrier""> <path d=""M6 12H18M6 12L11 7M6 12L11 17"" stroke=""currentcolor"" stroke-width=""2"" stroke-linecap=""round"" stroke-linejoin=""round""></path> </g>
                     </svg>
                ", w, h));
            };
        }

        public static RenderFragment EditIcon(int w, int h)
        {
            return (builder) =>
            {
                builder.AddMarkupContent(0, string.Format(@"
       	           <svg width=""{0}"" height=""{1}"" viewBox=""0 0 20 20"" fill=""currentcolor"" transform=""matrix(-1, 0, 0, 1, 0, 0)""><g id=""SVGRepo_bgCarrier"" stroke-width=""0""></g><g id=""SVGRepo_tracerCarrier"" stroke-linecap=""round"" stroke-linejoin=""round""></g><g id=""SVGRepo_iconCarrier""><path d=""M14.846 1.403l3.752 3.753.625-.626A2.653 2.653 0 0015.471.778l-.625.625zm2.029 5.472l-3.752-3.753L1.218 15.028 0 19.998l4.97-1.217L16.875 6.875z"" fill=""currentcolor""></path></g></svg>
                ", w, h));
            };
        }
        public static RenderFragment LogOutIcon(int w, int h)
        {
            return (builder) =>
            {
                builder.AddMarkupContent(0, string.Format(@"
       	          <svg width=""{0}"" height=""{1}"" viewBox=""0 0 24 24"" fill=""none""><g id=""SVGRepo_bgCarrier"" stroke-width=""0""></g><g id=""SVGRepo_tracerCarrier"" stroke-linecap=""round"" stroke-linejoin=""round""></g><g id=""SVGRepo_iconCarrier""> <path d=""M8.00195 7C8.01406 4.82497 8.11051 3.64706 8.87889 2.87868C9.75757 2 11.1718 2 14.0002 2H15.0002C17.8286 2 19.2429 2 20.1215 2.87868C21.0002 3.75736 21.0002 5.17157 21.0002 8V16C21.0002 18.8284 21.0002 20.2426 20.1215 21.1213C19.2429 22 17.8286 22 15.0002 22H14.0002C11.1718 22 9.75757 22 8.87889 21.1213C8.11051 20.3529 8.01406 19.175 8.00195 17"" stroke=""currentcolor"" stroke-width=""1.5"" stroke-linecap=""round""></path> <path d=""M8 19.5C5.64298 19.5 4.46447 19.5 3.73223 18.7678C3 18.0355 3 16.857 3 14.5V9.5C3 7.14298 3 5.96447 3.73223 5.23223C4.46447 4.5 5.64298 4.5 8 4.5"" stroke=""currentcolor"" stroke-width=""1.5""></path> <path d=""M15 12L6 12M6 12L8 14M6 12L8 10"" stroke=""#1C274C"" stroke-width=""1.5"" stroke-linecap=""round"" stroke-linejoin=""round""></path> </g></svg>
                ", w, h));
            };
        }

        public static RenderFragment VisibleIcon(int w, int h)
        {
            return (builder) =>
            {
                builder.AddMarkupContent(0, string.Format(@"
       	          <svg fill=""currentcolor"" width=""{0}"" height=""{1}"" viewBox=""0 0 64 64"" version=""1.1"" xml:space=""preserve""  style=""fill-rule:evenodd;clip-rule:evenodd;stroke-linejoin:round;stroke-miterlimit:2;""><g id=""SVGRepo_bgCarrier"" stroke-width=""0""></g><g id=""SVGRepo_tracerCarrier"" stroke-linecap=""round"" stroke-linejoin=""round""></g><g id=""SVGRepo_iconCarrier""> <rect id=""Icons"" x=""-896"" y=""-256"" width=""1280"" height=""800"" style=""fill:none;""></rect> <g id=""Icons1"" serif:id=""Icons""> <g id=""Strike""> </g> <g id=""H1""> </g> <g id=""H2""> </g> <g id=""H3""> </g> <g id=""list-ul""> </g> <g id=""hamburger-1""> </g> <g id=""hamburger-2""> </g> <g id=""list-ol""> </g> <g id=""list-task""> </g> <g id=""trash""> </g> <g id=""vertical-menu""> </g> <g id=""horizontal-menu""> </g> <g id=""sidebar-2""> </g> <g id=""Pen""> </g> <g id=""Pen1"" serif:id=""Pen""> </g> <g id=""clock""> </g> <g id=""external-link""> </g> <g id=""hr""> </g> <g id=""info""> </g> <g id=""warning""> </g> <g id=""plus-circle""> </g> <g id=""minus-circle""> </g> <g id=""vue""> </g> <g id=""cog""> </g> <g id=""logo""> </g> <g id=""radio-check""> </g> <g id=""eye-slash""> </g> <g id=""eye""> <path d=""M32.513,13.926c10.574,0.15 19.141,9.894 23.487,18.074c0,0 -1.422,2.892 -2.856,4.895c-0.694,0.969 -1.424,1.913 -2.191,2.826c-0.547,0.65 -1.112,1.283 -1.698,1.898c-5.237,5.5 -12.758,9.603 -20.7,8.01c-8.823,-1.77 -15.732,-9.498 -20.058,-17.629c0,0 1.248,-2.964 2.69,-4.964c0.646,-0.897 1.324,-1.77 2.034,-2.617c0.544,-0.649 1.108,-1.282 1.691,-1.897c4.627,-4.876 10.564,-8.63 17.601,-8.596Zm-0.037,4c-5.89,-0.022 -10.788,3.267 -14.663,7.35c-0.527,0.555 -1.035,1.127 -1.527,1.713c-0.647,0.772 -1.265,1.569 -1.854,2.386c-0.544,0.755 -1.057,1.805 -1.451,2.59c3.773,6.468 9.286,12.323 16.361,13.742c6.563,1.317 12.688,-2.301 17.016,-6.846c0.529,-0.555 1.04,-1.128 1.534,-1.715c0.7,-0.833 1.366,-1.694 1.999,-2.579c0.557,-0.778 1.144,-1.767 1.588,-2.567c-3.943,-6.657 -10.651,-13.944 -19.003,-14.074Z""></path> <path d=""M32.158,23.948c4.425,0 8.018,3.593 8.018,8.017c0,4.425 -3.593,8.017 -8.018,8.017c-4.424,0 -8.017,-3.592 -8.017,-8.017c0,-4.424 3.593,-8.017 8.017,-8.017Zm0,4.009c2.213,0 4.009,1.796 4.009,4.008c0,2.213 -1.796,4.009 -4.009,4.009c-2.212,0 -4.008,-1.796 -4.008,-4.009c0,-2.212 1.796,-4.008 4.008,-4.008Z""></path> </g> <g id=""toggle-off""> </g> <g id=""shredder""> </g> <g id=""spinner--loading--dots-"" serif:id=""spinner [loading, dots]""> </g> <g id=""react""> </g> <g id=""check-selected""> </g> <g id=""turn-off""> </g> <g id=""code-block""> </g> <g id=""user""> </g> <g id=""coffee-bean""> </g> <g id=""coffee-beans""> <g id=""coffee-bean1"" serif:id=""coffee-bean""> </g> </g> <g id=""coffee-bean-filled""> </g> <g id=""coffee-beans-filled""> <g id=""coffee-bean2"" serif:id=""coffee-bean""> </g> </g> <g id=""clipboard""> </g> <g id=""clipboard-paste""> </g> <g id=""clipboard-copy""> </g> <g id=""Layer1""> </g> </g> </g></svg>
                ", w, h));
            };
        }

        public static RenderFragment InVisibleIcon(int w, int h)
        {
            return (builder) =>
            {
                builder.AddMarkupContent(0, string.Format(@"
       	          <svg fill=""currentcolor"" width=""{1}"" height=""{1}"" viewBox=""0 0 64 64"" version=""1.1"" xml:space=""preserve"" style=""fill-rule:evenodd;clip-rule:evenodd;stroke-linejoin:round;stroke-miterlimit:2;""><g id=""SVGRepo_bgCarrier"" stroke-width=""0""></g><g id=""SVGRepo_tracerCarrier"" stroke-linecap=""round"" stroke-linejoin=""round""></g><g id=""SVGRepo_iconCarrier""> <rect id=""Icons"" x=""-960"" y=""-256"" width=""1280"" height=""800"" style=""fill:none;""></rect> <g id=""Icons1"" serif:id=""Icons""> <g id=""Strike""> </g> <g id=""H1""> </g> <g id=""H2""> </g> <g id=""H3""> </g> <g id=""list-ul""> </g> <g id=""hamburger-1""> </g> <g id=""hamburger-2""> </g> <g id=""list-ol""> </g> <g id=""list-task""> </g> <g id=""trash""> </g> <g id=""vertical-menu""> </g> <g id=""horizontal-menu""> </g> <g id=""sidebar-2""> </g> <g id=""Pen""> </g> <g id=""Pen1"" serif:id=""Pen""> </g> <g id=""clock""> </g> <g id=""external-link""> </g> <g id=""hr""> </g> <g id=""info""> </g> <g id=""warning""> </g> <g id=""plus-circle""> </g> <g id=""minus-circle""> </g> <g id=""vue""> </g> <g id=""cog""> </g> <g id=""logo""> </g> <g id=""radio-check""> </g> <g id=""eye-slash""> <path d=""M13.673,10.345l-3.097,3.096l39.853,39.854l3.097,-3.097l-39.853,-39.853Z""></path> <path d=""M17.119,19.984l2.915,2.915c-3.191,2.717 -5.732,6.099 -7.374,9.058l-0.005,0.01c4.573,7.646 11.829,14.872 20.987,13.776c2.472,-0.296 4.778,-1.141 6.885,-2.35l2.951,2.95c-4.107,2.636 -8.815,4.032 -13.916,3.342c-9.198,-1.244 -16.719,-8.788 -21.46,-17.648c2.226,-4.479 5.271,-8.764 9.017,-12.053Zm6.63,-4.32c2.572,-1.146 5.355,-1.82 8.327,-1.868c0.165,-0.001 2.124,0.092 3.012,0.238c0.557,0.092 1.112,0.207 1.659,0.35c8.725,2.273 15.189,10.054 19.253,17.653c-1.705,3.443 -3.938,6.398 -6.601,9.277l-2.827,-2.827c1.967,-2.12 3.622,-4.161 4.885,-6.45c0,0 -1.285,-2.361 -2.248,-3.643c-0.619,-0.824 -1.27,-1.624 -1.954,-2.395c-0.54,-0.608 -2.637,-2.673 -3.136,-3.103c-3.348,-2.879 -7.279,-5.138 -11.994,-5.1c-1.826,0.029 -3.582,0.389 -5.249,0.995l-3.127,-3.127Z"" style=""fill-rule:nonzero;""></path> <path d=""M25.054,27.92l2.399,2.398c-0.157,0.477 -0.243,0.987 -0.243,1.516c0,2.672 2.169,4.841 4.841,4.841c0.529,0 1.039,-0.085 1.516,-0.243l2.399,2.399c-1.158,0.65 -2.494,1.02 -3.915,1.02c-4.425,0 -8.017,-3.592 -8.017,-8.017c0,-1.421 0.371,-2.756 1.02,-3.914Zm6.849,-4.101c0.049,-0.001 0.099,-0.002 0.148,-0.002c4.425,0 8.017,3.593 8.017,8.017c0,0.05 0,0.099 -0.001,0.148l-8.164,-8.163Z""></path> </g> <g id=""eye""> </g> <g id=""toggle-off""> </g> <g id=""shredder""> </g> <g id=""spinner--loading--dots-"" serif:id=""spinner [loading, dots]""> </g> <g id=""react""> </g> <g id=""check-selected""> </g> <g id=""turn-off""> </g> <g id=""code-block""> </g> <g id=""user""> </g> <g id=""coffee-bean""> </g> <g id=""coffee-beans""> <g id=""coffee-bean1"" serif:id=""coffee-bean""> </g> </g> <g id=""coffee-bean-filled""> </g> <g id=""coffee-beans-filled""> <g id=""coffee-bean2"" serif:id=""coffee-bean""> </g> </g> <g id=""clipboard""> </g> <g id=""clipboard-paste""> </g> <g id=""clipboard-copy""> </g> <g id=""Layer1""> </g> </g> </g></svg>
                ", w, h));
            };
        }

        public static RenderFragment WarningIcon(int w, int h)
        {
            return (builder) =>
            {
                builder.AddMarkupContent(0, string.Format(@"
       	              <svg width=""{0}"" height=""{1}"" viewBox=""0 0 1024 1024"" fill=""currentcolor"">
                        <g id=""SVGRepo_bgCarrier"" stroke-width=""0""></g><g id=""SVGRepo_tracerCarrier"" stroke-linecap=""round"" stroke-linejoin=""round""></g>
                        <g id=""SVGRepo_iconCarrier""><path fill=""currentcolor"" d=""M512 64a448 448 0 1 1 0 896 448 448 0 0 1 0-896zm0 192a58.432 58.432 0 0 0-58.24 63.744l23.36 256.384a35.072 35.072 0 0 0 69.76 0l23.296-256.384A58.432 58.432 0 0 0 512 256zm0 512a51.2 51.2 0 1 0 0-102.4 51.2 51.2 0 0 0 0 102.4z""></path></g>
                      </svg>
                ", w, h));
            };
        }

        public static RenderFragment RecentIcon(int w, int h)
        {
            return (builder) =>
            {
                builder.AddMarkupContent(0, string.Format(@"
       	             <svg width=""{0}"" height=""{1}"" viewBox=""0 0 24 24"" id=""_24x24_On_Light_Recent"" data-name=""24x24/On Light/Recent"" fill=""currentcolor78""><g id=""SVGRepo_bgCarrier"" stroke-width=""0""></g><g id=""SVGRepo_tracerCarrier"" stroke-linecap=""round"" stroke-linejoin=""round""></g><g id=""SVGRepo_iconCarrier""> <rect id=""view-box"" width=""24"" height=""24"" fill=""none""></rect> <path id=""Shape"" d=""M9.682,18.75a.75.75,0,0,1,.75-.75,8.25,8.25,0,1,0-6.189-2.795V12.568a.75.75,0,0,1,1.5,0v4.243a.75.75,0,0,1-.751.75H.75a.75.75,0,0,1,0-1.5H3a9.75,9.75,0,1,1,7.433,3.44A.75.75,0,0,1,9.682,18.75Zm2.875-4.814L9.9,11.281a.754.754,0,0,1-.22-.531V5.55a.75.75,0,1,1,1.5,0v4.889l2.436,2.436a.75.75,0,1,1-1.061,1.06Z"" transform=""translate(1.568 2.25)"" fill=""currentcolor""></path> </g></svg>
                ", w, h));
            };
        }

        public static RenderFragment TrashIcon(int w, int h)
        {
            return (builder) =>
            {
                builder.AddMarkupContent(0, string.Format(@"
       	            <svg width=""{0}"" height=""{1}"" viewBox=""0 0 24 24"" fill=""none"" ><g id=""SVGRepo_bgCarrier"" stroke-width=""0""></g><g id=""SVGRepo_tracerCarrier"" stroke-linecap=""round"" stroke-linejoin=""round""></g><g id=""SVGRepo_iconCarrier""> <path d=""M3 6.38597C3 5.90152 3.34538 5.50879 3.77143 5.50879L6.43567 5.50832C6.96502 5.49306 7.43202 5.11033 7.61214 4.54412C7.61688 4.52923 7.62232 4.51087 7.64185 4.44424L7.75665 4.05256C7.8269 3.81241 7.8881 3.60318 7.97375 3.41617C8.31209 2.67736 8.93808 2.16432 9.66147 2.03297C9.84457 1.99972 10.0385 1.99986 10.2611 2.00002H13.7391C13.9617 1.99986 14.1556 1.99972 14.3387 2.03297C15.0621 2.16432 15.6881 2.67736 16.0264 3.41617C16.1121 3.60318 16.1733 3.81241 16.2435 4.05256L16.3583 4.44424C16.3778 4.51087 16.3833 4.52923 16.388 4.54412C16.5682 5.11033 17.1278 5.49353 17.6571 5.50879H20.2286C20.6546 5.50879 21 5.90152 21 6.38597C21 6.87043 20.6546 7.26316 20.2286 7.26316H3.77143C3.34538 7.26316 3 6.87043 3 6.38597Z"" fill=""currentcolor""></path> <path fill-rule=""evenodd"" clip-rule=""evenodd"" d=""M11.5956 22.0001H12.4044C15.1871 22.0001 16.5785 22.0001 17.4831 21.1142C18.3878 20.2283 18.4803 18.7751 18.6654 15.8686L18.9321 11.6807C19.0326 10.1037 19.0828 9.31524 18.6289 8.81558C18.1751 8.31592 17.4087 8.31592 15.876 8.31592H8.12404C6.59127 8.31592 5.82488 8.31592 5.37105 8.81558C4.91722 9.31524 4.96744 10.1037 5.06788 11.6807L5.33459 15.8686C5.5197 18.7751 5.61225 20.2283 6.51689 21.1142C7.42153 22.0001 8.81289 22.0001 11.5956 22.0001ZM10.2463 12.1886C10.2051 11.7548 9.83753 11.4382 9.42537 11.4816C9.01321 11.525 8.71251 11.9119 8.75372 12.3457L9.25372 17.6089C9.29494 18.0427 9.66247 18.3593 10.0746 18.3159C10.4868 18.2725 10.7875 17.8856 10.7463 17.4518L10.2463 12.1886ZM14.5746 11.4816C14.9868 11.525 15.2875 11.9119 15.2463 12.3457L14.7463 17.6089C14.7051 18.0427 14.3375 18.3593 13.9254 18.3159C13.5132 18.2725 13.2125 17.8856 13.2537 17.4518L13.7537 12.1886C13.7949 11.7548 14.1625 11.4382 14.5746 11.4816Z"" fill=""currentcolor""></path> </g></svg>
                ", w, h));
            };
        }

        public static RenderFragment PhoneIcon(int w, int h)
        {
            return (builder) =>
            {
                builder.AddMarkupContent(0, string.Format(@"
       	              <svg width=""{0}"" height=""{1}"" viewBox=""0 0 20 20"" version=""1.1""  fill=""currentcolor""><g id=""SVGRepo_bgCarrier"" stroke-width=""0""></g><g id=""SVGRepo_tracerCarrier"" stroke-linecap=""round"" stroke-linejoin=""round""></g><g id=""SVGRepo_iconCarrier""> <title>call [#191]</title> <desc>Created with Sketch.</desc> <defs> </defs> <g id=""Page-1"" stroke=""none"" stroke-width=""1"" fill=""none"" fill-rule=""evenodd""> <g id=""Dribbble-Light-Preview"" transform=""translate(-140.000000, -7319.000000)"" fill=""#00e2e6""> <g id=""icons"" transform=""translate(56.000000, 160.000000)""> <path d=""M94,7167 L94,7169 L96,7169 C96,7167.895 95.105,7167 94,7167 M94,7163 L94,7165 C96.206,7165 98,7166.794 98,7169 L100,7169 C100,7165.686 97.314,7163 94,7163 M94,7159 L94,7161 C98.411,7161 102,7164.589 102,7169 L104,7169 C104,7163.477 99.523,7159 94,7159 M98.652,7177.234 C98.641,7177.265 98.64,7177.27 98.652,7177.234 M98.117,7174.578 C97.422,7174.204 96.719,7173.778 95.992,7173.481 C94.587,7172.908 94.682,7174.602 93.679,7175.151 C93.027,7175.508 92.107,7174.861 91.538,7174.503 C90.544,7173.877 89.663,7173.053 88.931,7172.1 C88.556,7171.613 87.728,7170.697 87.83,7170.014 C87.992,7168.93 89.274,7168.876 88.907,7167.55 C88.711,7166.84 88.36,7166.141 88.097,7165.457 C87.745,7164.54 87.6,7163.953 86.573,7164.003 C85.831,7164.039 85.339,7164.356 84.883,7164.951 C83.649,7166.558 83.835,7168.725 84.664,7170.488 C85.838,7172.983 87.85,7175.335 89.999,7176.855 C91.461,7177.889 93.387,7178.828 95.157,7178.987 C96.453,7179.104 98.266,7178.403 98.73,7176.996 C98.698,7177.094 98.667,7177.189 98.652,7177.234 C98.663,7177.199 98.687,7177.128 98.73,7176.996 C98.777,7176.854 98.8,7176.783 98.811,7176.751 C98.797,7176.793 98.765,7176.891 98.731,7176.993 C99.139,7175.753 99.189,7175.155 98.117,7174.578 M98.811,7176.751 C98.819,7176.727 98.819,7176.725 98.811,7176.751"" id=""call-[#191]""> </path> </g> </g> </g> </g>
                    </svg>
                ", w, h));
            };
        }
        #endregion

        #region Navmenu

        public static RenderFragment AppIcon(int w, int h)
        {
            return (builder) =>
            {
                builder.AddMarkupContent(0, string.Format(@"
       	             <svg version=""1.1"" id=""Icons"" viewBox=""0 0 32 32"" xml:space=""preserve"" width=""{0}"" height=""{1}"" fill=""currentcolor"">
                        <g id=""SVGRepo_bgCarrier"" stroke-width=""0""/>
                        <g id=""SVGRepo_tracerCarrier"" stroke-linecap=""round"" stroke-linejoin=""round""/>
                        <g xmlns="""" id=""SVGRepo_iconCarrier""><g <path d=""M16,1c-2.3,0-4.7,4.5-5,11h10C20.7,5.5,18.3,1,16,1z""/> <path d=""M23,12h6c-0.4-5.7-4.5-10.3-9.9-11.6C21.3,2.5,22.8,6.8,23,12z""/> <path d=""M9,12c0.2-5.2,1.7-9.5,3.9-11.6C7.6,1.7,3.5,6.3,3.1,12H9z""/> </g> <path d=""M29.9,16.5C29.7,16.2,29.4,16,29,16c-2.2,0-4.3,1-5.6,2.8L22.5,20c-1.1,1.3-2.8,2-4.5,2h-3c-0.6,0-1-0.4-1-1s0.4-1,1-1h1.9 c1.6,0,3.1-1.3,3.1-2.9c0,0,0-0.1,0-0.1c0-0.5-0.5-1-1-1l-6.1,0c-3.6,0-6.5,1.6-8.1,4.2l-2.7,4.2c-0.2,0.3-0.2,0.7,0,1l3,5 c0.1,0.2,0.4,0.4,0.6,0.5c0.1,0,0.1,0,0.2,0c0.2,0,0.4-0.1,0.6-0.2c3.8-2.5,8.2-3.8,12.7-3.8c3.3,0,6.3-1.8,7.9-4.7l2.7-4.8 C30,17.2,30,16.8,29.9,16.5z""/> <path  d=""M28.9,14C28.9,14,28.9,14,28.9,14l-6,0c0,0.9-0.1,1.7-0.2,2.5C24.4,14.9,26.6,14,28.9,14z""/> <path  d=""M9.1,14.6c0-0.2,0-0.4,0-0.6h-6c0.1,1.4,0.4,2.7,0.9,4C5.3,16.4,7.1,15.2,9.1,14.6z""/> </g>
                      </svg>
                ", w, h));
            };
        }
        public static RenderFragment NavManuIcons(int w, int h, string type)
        {
            return type switch
            {
                MenuSection.Order => OrderIcon(w, h),
                MenuSection.Items => ItemsIcon(w,h),
                MenuSection.Main => MainIcon(w, h),
                _ => NavDefaultIcon(w, h)
            };
        }

        public static RenderFragment SettingIcon(int w, int h)
        {
            return (builder) =>
            {
                builder.AddMarkupContent(0, string.Format(@"
       	             <svg width=""{0}"" height=""{1}"" viewBox=""0 0 1024 1024"" fill=""currentcolor"">
                      <g id=""SVGRepo_bgCarrier"" stroke-width=""0""/>
                        <g id=""SVGRepo_tracerCarrier"" stroke-linecap=""round"" stroke-linejoin=""round""/>
                        <g id=""SVGRepo_iconCarrier"">
                        <path fill=""currencolor"" d=""M600.704 64a32 32 0 0 1 30.464 22.208l35.2 109.376c14.784 7.232 28.928 15.36 42.432 24.512l112.384-24.192a32 32 0 0 1 34.432 15.36L944.32 364.8a32 32 0 0 1-4.032 37.504l-77.12 85.12a357.12 357.12 0 0 1 0 49.024l77.12 85.248a32 32 0 0 1 4.032 37.504l-88.704 153.6a32 32 0 0 1-34.432 15.296L708.8 803.904c-13.44 9.088-27.648 17.28-42.368 24.512l-35.264 109.376A32 32 0 0 1 600.704 960H423.296a32 32 0 0 1-30.464-22.208L357.696 828.48a351.616 351.616 0 0 1-42.56-24.64l-112.32 24.256a32 32 0 0 1-34.432-15.36L79.68 659.2a32 32 0 0 1 4.032-37.504l77.12-85.248a357.12 357.12 0 0 1 0-48.896l-77.12-85.248A32 32 0 0 1 79.68 364.8l88.704-153.6a32 32 0 0 1 34.432-15.296l112.32 24.256c13.568-9.152 27.776-17.408 42.56-24.64l35.2-109.312A32 32 0 0 1 423.232 64H600.64zm-23.424 64H446.72l-36.352 113.088-24.512 11.968a294.113 294.113 0 0 0-34.816 20.096l-22.656 15.36-116.224-25.088-65.28 113.152 79.68 88.192-1.92 27.136a293.12 293.12 0 0 0 0 40.192l1.92 27.136-79.808 88.192 65.344 113.152 116.224-25.024 22.656 15.296a294.113 294.113 0 0 0 34.816 20.096l24.512 11.968L446.72 896h130.688l36.48-113.152 24.448-11.904a288.282 288.282 0 0 0 34.752-20.096l22.592-15.296 116.288 25.024 65.28-113.152-79.744-88.192 1.92-27.136a293.12 293.12 0 0 0 0-40.256l-1.92-27.136 79.808-88.128-65.344-113.152-116.288 24.96-22.592-15.232a287.616 287.616 0 0 0-34.752-20.096l-24.448-11.904L577.344 128zM512 320a192 192 0 1 1 0 384 192 192 0 0 1 0-384zm0 64a128 128 0 1 0 0 256 128 128 0 0 0 0-256z""/>
                        </g>
                      </svg>
                ", w, h));
            };
        }

        public static RenderFragment MainIcon(int w, int h)
        {
            return (builder) =>
            {
                builder.AddMarkupContent(0, string.Format(@"
       	            <svg width=""{0}"" height=""{1}"" viewBox=""0 0 24 24"" fill=""none"">
                        <g id=""SVGRepo_bgCarrier"" stroke-width=""0""/>
                        <g id=""SVGRepo_tracerCarrier"" stroke-linecap=""round"" stroke-linejoin=""round""/>
                        <g xmlns="""" id=""SVGRepo_iconCarrier""> <path d=""M2 12.2039C2 9.91549 2 8.77128 2.5192 7.82274C3.0384 6.87421 3.98695 6.28551 5.88403 5.10813L7.88403 3.86687C9.88939 2.62229 10.8921 2 12 2C13.1079 2 14.1106 2.62229 16.116 3.86687L18.116 5.10812C20.0131 6.28551 20.9616 6.87421 21.4808 7.82274C22 8.77128 22 9.91549 22 12.2039V13.725C22 17.6258 22 19.5763 20.8284 20.7881C19.6569 22 17.7712 22 14 22H10C6.22876 22 4.34315 22 3.17157 20.7881C2 19.5763 2 17.6258 2 13.725V12.2039Z"" stroke=""currentcolor"" stroke-width=""1.5""/> <path d=""M15 18H9"" stroke=""currentcolor"" stroke-width=""1.5"" stroke-linecap=""round""/> </g>
                    </svg>
                ", w, h));
            };
        }

        public static RenderFragment SetupIcon(int w, int h)
        {
            return (builder) =>
            {
                builder.AddMarkupContent(0, string.Format(@"
       	            <svg width=""{0}"" height=""{1}"" viewBox=""0 0 24 24"" fill=""none"">
                        <g id=""SVGRepo_bgCarrier"" stroke-width=""0""/>
                        <g id=""SVGRepo_tracerCarrier"" stroke-linecap=""round"" stroke-linejoin=""round""/>
                        <g id=""SVGRepo_iconCarrier""> <path d=""M9 22H15C20 22 22 20 22 15V9C22 4 20 2 15 2H9C4 2 2 4 2 9V15C2 20 4 22 9 22Z"" stroke=""currentcolor"" stroke-width=""1.5"" stroke-linecap=""round"" stroke-linejoin=""round""/> <path d=""M15.5699 18.5001V14.6001"" stroke=""currentcolor"" stroke-width=""1.5"" stroke-miterlimit=""10"" stroke-linecap=""round"" stroke-linejoin=""round""/> <path d=""M15.5699 7.45V5.5"" stroke=""currentcolor"" stroke-width=""1.5"" stroke-miterlimit=""10"" stroke-linecap=""round"" stroke-linejoin=""round""/> <path d=""M15.57 12.65C17.0059 12.65 18.17 11.4859 18.17 10.05C18.17 8.61401 17.0059 7.44995 15.57 7.44995C14.134 7.44995 12.97 8.61401 12.97 10.05C12.97 11.4859 14.134 12.65 15.57 12.65Z"" stroke=""currentcolor"" stroke-width=""1.5"" stroke-miterlimit=""10"" stroke-linecap=""round"" stroke-linejoin=""round""/> <path d=""M8.43005 18.5V16.55"" stroke=""currentcolor"" stroke-width=""1.5"" stroke-miterlimit=""10"" stroke-linecap=""round"" stroke-linejoin=""round""/> <path d=""M8.43005 9.4V5.5"" stroke=""currentcolor"" stroke-width=""1.5"" stroke-miterlimit=""10"" stroke-linecap=""round"" stroke-linejoin=""round""/> <path d=""M8.42996 16.5501C9.8659 16.5501 11.03 15.386 11.03 13.9501C11.03 12.5142 9.8659 11.3501 8.42996 11.3501C6.99402 11.3501 5.82996 12.5142 5.82996 13.9501C5.82996 15.386 6.99402 16.5501 8.42996 16.5501Z"" stroke=""currentcolor"" stroke-width=""1.5"" stroke-miterlimit=""10"" stroke-linecap=""round"" stroke-linejoin=""round""/> </g>
                     </svg>
                ", w, h));
            };
        }

        public static RenderFragment OrderIcon(int w, int h)
        {
            return (builder) =>
            {
                builder.AddMarkupContent(0, string.Format(@"
       	             <svg width=""{0}"" height=""{1}"" viewBox=""0 0 24 24"" fill=""none"">
                        <g id=""SVGRepo_bgCarrier"" stroke-width=""0""/>
                        <g id=""SVGRepo_tracerCarrier"" stroke-linecap=""round"" stroke-linejoin=""round""/>
                        <g id=""SVGRepo_iconCarrier""> <path d=""M7.5 18C8.32843 18 9 18.6716 9 19.5C9 20.3284 8.32843 21 7.5 21C6.67157 21 6 20.3284 6 19.5C6 18.6716 6.67157 18 7.5 18Z"" stroke=""currentcolor"" stroke-width=""1.5""/> <path d=""M16.5 18.0001C17.3284 18.0001 18 18.6716 18 19.5001C18 20.3285 17.3284 21.0001 16.5 21.0001C15.6716 21.0001 15 20.3285 15 19.5001C15 18.6716 15.6716 18.0001 16.5 18.0001Z"" stroke=""currentcolor"" stroke-width=""1.5""/> <path d=""M11 10.8L12.1429 12L15 9"" stroke=""currentcolor"" stroke-width=""1.5"" stroke-linecap=""round"" stroke-linejoin=""round""/> <path d=""M2 3L2.26121 3.09184C3.5628 3.54945 4.2136 3.77826 4.58584 4.32298C4.95808 4.86771 4.95808 5.59126 4.95808 7.03836V9.76C4.95808 12.7016 5.02132 13.6723 5.88772 14.5862C6.75412 15.5 8.14857 15.5 10.9375 15.5H12M16.2404 15.5C17.8014 15.5 18.5819 15.5 19.1336 15.0504C19.6853 14.6008 19.8429 13.8364 20.158 12.3075L20.6578 9.88275C21.0049 8.14369 21.1784 7.27417 20.7345 6.69708C20.2906 6.12 18.7738 6.12 17.0888 6.12H11.0235M4.95808 6.12H7"" stroke=""currentcolor"" stroke-width=""1.5"" stroke-linecap=""round""/> </g>
                      </svg>
                ", w, h));
            };
        }

        public static RenderFragment ItemsIcon(int w, int h)
        {
            return (builder) =>
            {
                builder.AddMarkupContent(0, string.Format(@"
       	            <svg fill=""currentcolor"" height=""{0}"" width=""{1}"" version=""1.1"" id=""Capa_1""  viewBox=""0 0 489.147 489.147"" xml:space=""preserve""><g id=""SVGRepo_bgCarrier"" stroke-width=""0""></g><g id=""SVGRepo_tracerCarrier"" stroke-linecap=""round"" stroke-linejoin=""round""></g><g id=""SVGRepo_iconCarrier""> <g> <g> <g> <path d=""M181.474,441.747c68.4,0,124.3-56.7,127.4-127.8h-254.8C57.174,385.047,113.074,441.747,181.474,441.747z M248.674,342.347h3.5c5.4,0,9.7,4.3,9.7,9.7c0,5.4-4.3,9.7-9.7,9.7h-3.5c-5.4,0-9.7-4.3-9.7-9.7 S243.174,342.347,248.674,342.347z M224.174,376.147h3.5c5.4,0,9.7,4.3,9.7,9.7c0,5.4-4.3,9.7-9.7,9.7h-3.5 c-5.4,0-9.7-4.3-9.7-9.7C214.474,380.347,218.774,376.147,224.174,376.147z M195.474,411.847c-1.2,4.3-5.8,8.4-13.6,6.6 c-5.4,0.8-10.1-2.7-11.3-7.8c-0.8-5.4,2.7-10.1,7.8-11.3c3.5-0.8,7-0.4,10.5,0.8 C194.274,401.347,196.974,406.847,195.474,411.847z M165.874,346.947c1.6-5,7.4-7.8,12.4-5.8l1.6,0.4c5,1.6,7.8,7.4,6.2,12.4 c-0.7,4.1-7.7,8.8-14.4,5.4C167.074,357.447,164.374,352.047,165.874,346.947z M128.274,376.147c5.8-0.4,11.7,3.1,14.4,8.5 c2.3,4.7,0.4,10.5-4.7,12.8c-4.8,2.1-9.7-0.4-11.7-2.7c-4.3-0.8-7.4-4.7-7.4-8.9 C118.574,380.747,122.774,376.147,128.274,376.147z M88.274,360.147c-3.5-1.9-5.8-6.2-4.7-10.5c1.2-5,6.2-8.5,11.7-7.4 c5,1.2,8.9,4.7,10.5,9.7s-1.2,10.5-6.2,12C93.874,365.747,90.174,362.947,88.274,360.147z""></path> <path d=""M356.674,314.347h-28c-3.1,81.6-68,147.2-146.8,147.2c-79.3,0-143.7-65.2-146.8-147.2h-28.4 c0,96.7,78.5,174.8,174.8,174.8S356.674,410.647,356.674,314.347z""></path> <path d=""M461.474,108.547h-47.8l6.2-56.3l53.7-34.6c4.7-2.7,5.8-8.9,2.7-13.2c-2.7-4.7-8.9-5.8-13.2-2.7l-57.1,36.8 c-2.3,1.6-3.9,4.3-4.3,7l-6.6,61.8c0,0.4,0,0.8,0,1.2h-189.5l-20.2,45.4h297.1L461.474,108.547z""></path> <path d=""M212.874,294.947h162.7v19.4c0,76.9-45.1,143.3-109.9,174.8h166.6l35-315.8h-268L212.874,294.947z""></path> </g> </g> </g> </g>
                    </svg>
                ", w, h));
            };
        }

        public static RenderFragment PrinterIcon(int w, int h)
        {
            return (builder) =>
            {
                builder.AddMarkupContent(0, string.Format(@"
       	            <svg width=""{0}"" height=""{1}"" viewBox=""0 0 64 64"" aria-hidden=""true"" role=""img"" class=""iconify iconify--emojione-monotone"" preserveAspectRatio=""xMidYMid meet"" fill=""currentcolor"">
                                    <g id=""SVGRepo_bgCarrier"" stroke-width=""0""/>
                                    <g id=""SVGRepo_tracerCarrier"" stroke-linecap=""round"" stroke-linejoin=""round""/>
                                    <g id=""SVGRepo_iconCarrier"">
                                    <path d=""M19.897 51.322c-.95 2.449-2.418 4.771-3.829 7.012c-.313.498.525.947.837.449c1.454-2.309 2.947-4.699 3.927-7.225c.212-.54-.726-.771-.935-.236"" fill=""currentcolor""/>
                                    <path d=""M44.103 51.322c-.209-.535-1.146-.305-.936.236c.98 2.525 2.473 4.916 3.928 7.225c.312.498 1.15.049.836-.449c-1.41-2.24-2.879-4.563-3.828-7.012"" fill=""currentcolor""/>
                                    <path d=""M52 16h-5V4c0-1.1-.899-2-2-2H19c-1.1 0-2 .9-2 2v12h-5C8.319 16 2 21.088 2 26.805S4.24 54 4.24 54H7v4c0 1.1.9 2 2 2h2.022c-.205 1.697 1.759 2 4.111 2c1.272 0 2.656-.087 3.867-.087h26c1.211 0 2.595.087 3.867.087c2.353 0 4.315-.303 4.111-2H55c1.101 0 2-.9 2-2v-4h2.76S62 32.521 62 26.805S55.681 16 52 16m-33 0V5c0-.549.45-1 1-1h24c.55 0 1 .451 1 1v15h-1V10H20v10h-1v-4m23-4v8H22v-8h20M8.696 52h-2.65C5.512 46.732 4 31.397 4 26.805c0-4.152 4.348-7.916 7.102-8.662C8.912 20.156 7 23.361 7 26.805C7 31.455 8.235 46.537 8.696 52M12 41.5c0-.186.065-.35.154-.5c.175.293.481.5.846.5h2a.99.99 0 0 0 .846-.5c.089.15.154.314.154.5c0 .551-.45 1-1 1h-2c-.55 0-1-.449-1-1m8-2.5h-7c-.55 0-1-.449-1-1v-4c0-.549.45-1 1-1h7c.55 0 1 .451 1 1v4c0 .551-.45 1-1 1m1 2.5c0 .551-.45 1-1 1h-2c-.55 0-1-.449-1-1c0-.186.065-.35.154-.5c.175.293.481.5.846.5h2a.99.99 0 0 0 .846-.5c.089.15.154.314.154.5M48.867 60c-.622 0-1.272-.021-1.915-.043c-.67-.022-1.333-.044-1.952-.044H19c-.619 0-1.282.021-1.953.044c-.642.022-1.292.043-1.914.043c-1.056 0-1.662-.072-2.002-.144c.106-.239.298-.597.645-1.093c2.539-3.637 3.982-6.49 4.688-8.061h3.299C21.368 52.386 20.554 54.991 19 57h5.24c-.153.481-.307.965-.464 1.441c-.182.551.754.783.935.236c.183-.555.36-1.117.537-1.678h6.267v1.559c0 .574.971.574.971 0v-1.559h6.267c.177.561.354 1.123.537 1.678c.181.547 1.116.314.935-.236c-.157-.477-.311-.96-.464-1.441H45c-1.554-2.009-2.368-4.614-2.762-6.297h3.3c.705 1.57 2.148 4.424 4.688 8.061c.346.496.537.854.645 1.093c-.343.071-.948.143-2.004.143m-27.198-4.5c.869-1.775 1.363-3.572 1.63-4.797h17.402c.267 1.225.761 3.021 1.63 4.797H21.669M50 39a1 1 0 1 1 0-2a1 1 0 0 1 0 2m0-4a1 1 0 1 1 0-2a1 1 0 0 1 0 2m-18-7c-21 0-21-.447-21-1s0-1 21-1s21 .447 21 1s0 1-21 1m25.954 24h-2.65C55.765 46.537 57 31.455 57 26.805c0-3.443-1.912-6.648-4.102-8.662c2.754.746 7.102 4.509 7.102 8.662c0 4.592-1.513 19.927-2.046 25.195"" fill=""currentcolor""/>
                                    <path d=""M32 9a6.998 6.998 0 0 0 6.454-4.287a7.978 7.978 0 0 1-12.908 0A6.998 6.998 0 0 0 32 9z"" fill=""currentcolor""/>
                                    </g>
                               </svg>
                ", w, h));
            };
        }

        public static RenderFragment PermissionIcon(int w, int h)
        {
            return (builder) =>
            {
                builder.AddMarkupContent(0, string.Format(@"
       	             <svg width=""{0}"" height=""{1}"" viewBox=""0 0 24 24"" fill=""none"">
                                <g id=""SVGRepo_bgCarrier"" stroke-width=""0""/>
                                <g id=""SVGRepo_tracerCarrier"" stroke-linecap=""round"" stroke-linejoin=""round""/>
                                <g id=""SVGRepo_iconCarrier""> <path fill-rule=""evenodd"" clip-rule=""evenodd"" d=""M6.75 8C6.75 5.10051 9.10051 2.75 12 2.75C14.4453 2.75 16.5018 4.42242 17.0846 6.68694C17.1879 7.08808 17.5968 7.32957 17.9979 7.22633C18.3991 7.12308 18.6405 6.7142 18.5373 6.31306C17.788 3.4019 15.1463 1.25 12 1.25C8.27208 1.25 5.25 4.27208 5.25 8V10.0546C4.13525 10.1379 3.40931 10.348 2.87868 10.8787C2 11.7574 2 13.1716 2 16C2 18.8284 2 20.2426 2.87868 21.1213C3.75736 22 5.17157 22 8 22H16C18.8284 22 20.2426 22 21.1213 21.1213C22 20.2426 22 18.8284 22 16C22 13.1716 22 11.7574 21.1213 10.8787C20.2426 10 18.8284 10 16 10H8C7.54849 10 7.13301 10 6.75 10.0036V8ZM8 17C8.55228 17 9 16.5523 9 16C9 15.4477 8.55228 15 8 15C7.44772 15 7 15.4477 7 16C7 16.5523 7.44772 17 8 17ZM12 17C12.5523 17 13 16.5523 13 16C13 15.4477 12.5523 15 12 15C11.4477 15 11 15.4477 11 16C11 16.5523 11.4477 17 12 17ZM17 16C17 16.5523 16.5523 17 16 17C15.4477 17 15 16.5523 15 16C15 15.4477 15.4477 15 16 15C16.5523 15 17 15.4477 17 16Z"" fill=""currentcolor""/> </g>
                              </svg>
                ", w, h));
            };
        }

        public static RenderFragment NavDefaultIcon(int w, int h)
        {
            return (builder) =>
            {
                builder.AddMarkupContent(0, string.Format(@"
       	             <svg width=""{0}"" height=""{1}"" viewBox=""0 0 15 15"" fill=""none"">
                                <g id=""SVGRepo_bgCarrier"" stroke-width=""0""/>
                                <g id=""SVGRepo_tracerCarrier"" stroke-linecap=""round"" stroke-linejoin=""round""/>
                                <g id=""SVGRepo_iconCarrier""> <path fill-rule=""evenodd"" clip-rule=""evenodd"" d=""M2.8 1L2.74967 0.99997C2.52122 0.999752 2.32429 0.999564 2.14983 1.04145C1.60136 1.17312 1.17312 1.60136 1.04145 2.14983C0.999564 2.32429 0.999752 2.52122 0.99997 2.74967L1 2.8V5.2L0.99997 5.25033C0.999752 5.47878 0.999564 5.67572 1.04145 5.85017C1.17312 6.39864 1.60136 6.82688 2.14983 6.95856C2.32429 7.00044 2.52122 7.00025 2.74967 7.00003L2.8 7H5.2L5.25033 7.00003C5.47878 7.00025 5.67572 7.00044 5.85017 6.95856C6.39864 6.82688 6.82688 6.39864 6.95856 5.85017C7.00044 5.67572 7.00025 5.47878 7.00003 5.25033L7 5.2V2.8L7.00003 2.74967C7.00025 2.52122 7.00044 2.32429 6.95856 2.14983C6.82688 1.60136 6.39864 1.17312 5.85017 1.04145C5.67572 0.999564 5.47878 0.999752 5.25033 0.99997L5.2 1H2.8ZM2.38328 2.01382C2.42632 2.00348 2.49222 2 2.8 2H5.2C5.50779 2 5.57369 2.00348 5.61672 2.01382C5.79955 2.05771 5.94229 2.20045 5.98619 2.38328C5.99652 2.42632 6 2.49222 6 2.8V5.2C6 5.50779 5.99652 5.57369 5.98619 5.61672C5.94229 5.79955 5.79955 5.94229 5.61672 5.98619C5.57369 5.99652 5.50779 6 5.2 6H2.8C2.49222 6 2.42632 5.99652 2.38328 5.98619C2.20045 5.94229 2.05771 5.79955 2.01382 5.61672C2.00348 5.57369 2 5.50779 2 5.2V2.8C2 2.49222 2.00348 2.42632 2.01382 2.38328C2.05771 2.20045 2.20045 2.05771 2.38328 2.01382ZM9.8 1L9.74967 0.99997C9.52122 0.999752 9.32429 0.999564 9.14983 1.04145C8.60136 1.17312 8.17312 1.60136 8.04145 2.14983C7.99956 2.32429 7.99975 2.52122 7.99997 2.74967L8 2.8V5.2L7.99997 5.25033C7.99975 5.47878 7.99956 5.67572 8.04145 5.85017C8.17312 6.39864 8.60136 6.82688 9.14983 6.95856C9.32429 7.00044 9.52122 7.00025 9.74967 7.00003L9.8 7H12.2L12.2503 7.00003C12.4788 7.00025 12.6757 7.00044 12.8502 6.95856C13.3986 6.82688 13.8269 6.39864 13.9586 5.85017C14.0004 5.67572 14.0003 5.47878 14 5.25033L14 5.2V2.8L14 2.74967C14.0003 2.52122 14.0004 2.32429 13.9586 2.14983C13.8269 1.60136 13.3986 1.17312 12.8502 1.04145C12.6757 0.999564 12.4788 0.999752 12.2503 0.99997L12.2 1H9.8ZM9.38328 2.01382C9.42632 2.00348 9.49222 2 9.8 2H12.2C12.5078 2 12.5737 2.00348 12.6167 2.01382C12.7995 2.05771 12.9423 2.20045 12.9862 2.38328C12.9965 2.42632 13 2.49222 13 2.8V5.2C13 5.50779 12.9965 5.57369 12.9862 5.61672C12.9423 5.79955 12.7995 5.94229 12.6167 5.98619C12.5737 5.99652 12.5078 6 12.2 6H9.8C9.49222 6 9.42632 5.99652 9.38328 5.98619C9.20045 5.94229 9.05771 5.79955 9.01382 5.61672C9.00348 5.57369 9 5.50779 9 5.2V2.8C9 2.49222 9.00348 2.42632 9.01382 2.38328C9.05771 2.20045 9.20045 2.05771 9.38328 2.01382ZM2.74967 7.99997L2.8 8H5.2L5.25033 7.99997C5.47878 7.99975 5.67572 7.99956 5.85017 8.04145C6.39864 8.17312 6.82688 8.60136 6.95856 9.14983C7.00044 9.32429 7.00025 9.52122 7.00003 9.74967L7 9.8V12.2L7.00003 12.2503C7.00025 12.4788 7.00044 12.6757 6.95856 12.8502C6.82688 13.3986 6.39864 13.8269 5.85017 13.9586C5.67572 14.0004 5.47878 14.0003 5.25033 14L5.2 14H2.8L2.74967 14C2.52122 14.0003 2.32429 14.0004 2.14983 13.9586C1.60136 13.8269 1.17312 13.3986 1.04145 12.8502C0.999564 12.6757 0.999752 12.4788 0.99997 12.2503L1 12.2V9.8L0.99997 9.74967C0.999752 9.52122 0.999564 9.32429 1.04145 9.14983C1.17312 8.60136 1.60136 8.17312 2.14983 8.04145C2.32429 7.99956 2.52122 7.99975 2.74967 7.99997ZM2.8 9C2.49222 9 2.42632 9.00348 2.38328 9.01382C2.20045 9.05771 2.05771 9.20045 2.01382 9.38328C2.00348 9.42632 2 9.49222 2 9.8V12.2C2 12.5078 2.00348 12.5737 2.01382 12.6167C2.05771 12.7995 2.20045 12.9423 2.38328 12.9862C2.42632 12.9965 2.49222 13 2.8 13H5.2C5.50779 13 5.57369 12.9965 5.61672 12.9862C5.79955 12.9423 5.94229 12.7995 5.98619 12.6167C5.99652 12.5737 6 12.5078 6 12.2V9.8C6 9.49222 5.99652 9.42632 5.98619 9.38328C5.94229 9.20045 5.79955 9.05771 5.61672 9.01382C5.57369 9.00348 5.50779 9 5.2 9H2.8ZM9.8 8L9.74967 7.99997C9.52122 7.99975 9.32429 7.99956 9.14983 8.04145C8.60136 8.17312 8.17312 8.60136 8.04145 9.14983C7.99956 9.32429 7.99975 9.52122 7.99997 9.74967L8 9.8V12.2L7.99997 12.2503C7.99975 12.4788 7.99956 12.6757 8.04145 12.8502C8.17312 13.3986 8.60136 13.8269 9.14983 13.9586C9.32429 14.0004 9.52122 14.0003 9.74967 14L9.8 14H12.2L12.2503 14C12.4788 14.0003 12.6757 14.0004 12.8502 13.9586C13.3986 13.8269 13.8269 13.3986 13.9586 12.8502C14.0004 12.6757 14.0003 12.4788 14 12.2503L14 12.2V9.8L14 9.74967C14.0003 9.52122 14.0004 9.32429 13.9586 9.14983C13.8269 8.60136 13.3986 8.17312 12.8502 8.04145C12.6757 7.99956 12.4788 7.99975 12.2503 7.99997L12.2 8H9.8ZM9.38328 9.01382C9.42632 9.00348 9.49222 9 9.8 9H12.2C12.5078 9 12.5737 9.00348 12.6167 9.01382C12.7995 9.05771 12.9423 9.20045 12.9862 9.38328C12.9965 9.42632 13 9.49222 13 9.8V12.2C13 12.5078 12.9965 12.5737 12.9862 12.6167C12.9423 12.7995 12.7995 12.9423 12.6167 12.9862C12.5737 12.9965 12.5078 13 12.2 13H9.8C9.49222 13 9.42632 12.9965 9.38328 12.9862C9.20045 12.9423 9.05771 12.7995 9.01382 12.6167C9.00348 12.5737 9 12.5078 9 12.2V9.8C9 9.49222 9.00348 9.42632 9.01382 9.38328C9.05771 9.20045 9.20045 9.05771 9.38328 9.01382Z"" fill=""currentcolor""/> </g>
                               </svg>
                ", w, h));
            };
        }
        public static RenderFragment NavIndicatorIcon(int w, int h)
        {
            return (builder) =>
            {
                builder.AddMarkupContent(0, string.Format(@"
       	            <svg width=""{0}"" height=""{1}"" viewBox=""0 0 24 24"" fill=""none"">
                        <g id=""SVGRepo_bgCarrier"" stroke-width=""0""/>
                        <g id=""SVGRepo_tracerCarrier"" stroke-linecap=""round"" stroke-linejoin=""round""/>
                        <g id=""SVGRepo_iconCarrier""> <path d=""M4 12H20M20 12L16 8M20 12L16 16"" stroke=""currentcolor"" stroke-width=""2"" stroke-linecap=""round"" stroke-linejoin=""round""/> </g>
                    </svg>
                ", w, h));
            };
        }

        public static RenderFragment NavIndicatorIcon2(int w, int h)
        {
            return (builder) =>
            {
                builder.AddMarkupContent(0, string.Format(@"
       	            <svg width=""{0}"" height=""{1}"" viewBox=""0 0 24 24"" fill=""none"" transform=""matrix(1, 0, 0, -1, 0, 0)rotate(90)"">
                        <g id=""SVGRepo_bgCarrier"" stroke-width=""0""/>
                        <g id=""SVGRepo_tracerCarrier"" stroke-linecap=""round"" stroke-linejoin=""round""/>
                        <g xmlns="""" id=""SVGRepo_iconCarrier""> <path d=""M18.6806 13.9783L15.4706 10.7683L13.5106 8.79828C12.6806 7.96828 11.3306 7.96828 10.5006 8.79828L5.32056 13.9783C4.64056 14.6583 5.13056 15.8183 6.08056 15.8183H11.6906H17.9206C18.8806 15.8183 19.3606 14.6583 18.6806 13.9783Z"" fill=""currentcolor""/> </g>
                    </svg>
                ", w, h));
            };
        }
        #endregion

        #region MainHeader
        public static RenderFragment BellIcon(int w, int h)
        {
            return (builder) =>
            {
                builder.AddMarkupContent(0, string.Format(@"
       	             <svg fill=""currentcolor"" width=""{0}"" height=""{1}"" viewBox=""0 0 36 36"" version=""1.1"" preserveAspectRatio=""xMidYMid meet"">
                            <g id=""SVGRepo_bgCarrier"" stroke-width=""0""/>
                            <g id=""SVGRepo_tracerCarrier"" stroke-linecap=""round"" stroke-linejoin=""round""/>
                            <g id=""SVGRepo_iconCarrier""> <title>bell-outline-badged</title> <path class=""clr-i-outline--badged clr-i-outline-path-1--badged"" d=""M18,34.28A2.67,2.67,0,0,0,20.58,32H15.32A2.67,2.67,0,0,0,18,34.28Z""/>
                            <path class=""clr-i-outline--badged clr-i-outline-path-2--badged"" d=""M32.51,27.83A14.4,14.4,0,0,1,30,24.9a12.63,12.63,0,0,1-1.35-4.81V15.15a10.92,10.92,0,0,0-.16-1.79,7.44,7.44,0,0,1-2.24-.84,8.89,8.89,0,0,1,.4,2.64v4.94a14.24,14.24,0,0,0,1.65,5.85,16.17,16.17,0,0,0,2.44,3H5.13a16.17,16.17,0,0,0,2.44-3,14.24,14.24,0,0,0,1.65-5.85V15.15A8.8,8.8,0,0,1,18,6.31a8.61,8.61,0,0,1,4.76,1.44A7.49,7.49,0,0,1,22.5,6c0-.21,0-.42,0-.63a10.58,10.58,0,0,0-3.32-1V3.11a1.33,1.33,0,1,0-2.67,0V4.42A10.81,10.81,0,0,0,7.21,15.15v4.94A12.63,12.63,0,0,1,5.86,24.9a14.4,14.4,0,0,1-2.47,2.93,1,1,0,0,0-.34.75v1.36a1,1,0,0,0,1,1h27.8a1,1,0,0,0,1-1V28.58A1,1,0,0,0,32.51,27.83Z""/>
                            <circle class=""clr-i-outline--badged clr-i-outline-path-1--badged clr-i-badge"" cx=""30"" cy=""6"" r=""5""/> <rect x=""0"" y=""0"" width=""36"" height=""36"" fill-opacity=""0""/> </g>
                      </svg>
                ", w, h));
            };
        }

        public static RenderFragment ProfileIcon(int w, int h)
        {
            return (builder) =>
            {
                builder.AddMarkupContent(0, string.Format(@"
       	           <svg width=""{0}"" height=""{1}"" viewBox=""0 0 32 32"" version=""1.1"" fill=""currentcolor"">
                        <g id=""SVGRepo_bgCarrier"" stroke-width=""0""/>
                        <g id=""SVGRepo_tracerCarrier"" stroke-linecap=""round"" stroke-linejoin=""round""/>
                        <g id=""SVGRepo_iconCarrier""> <g id=""icomoon-ignore""> </g> <path d=""M16 3.205c-7.067 0-12.795 5.728-12.795 12.795s5.728 12.795 12.795 12.795 12.795-5.728 12.795-12.795c0-7.067-5.728-12.795-12.795-12.795zM16 4.271c6.467 0 11.729 5.261 11.729 11.729 0 2.845-1.019 5.457-2.711 7.49-1.169-0.488-3.93-1.446-5.638-1.951-0.146-0.046-0.169-0.053-0.169-0.66 0-0.501 0.206-1.005 0.407-1.432 0.218-0.464 0.476-1.244 0.569-1.944 0.259-0.301 0.612-0.895 0.839-2.026 0.199-0.997 0.106-1.36-0.026-1.7-0.014-0.036-0.028-0.071-0.039-0.107-0.050-0.234 0.019-1.448 0.189-2.391 0.118-0.647-0.030-2.022-0.921-3.159-0.562-0.719-1.638-1.601-3.603-1.724l-1.078 0.001c-1.932 0.122-3.008 1.004-3.57 1.723-0.89 1.137-1.038 2.513-0.92 3.159 0.172 0.943 0.239 2.157 0.191 2.387-0.010 0.040-0.025 0.075-0.040 0.111-0.131 0.341-0.225 0.703-0.025 1.7 0.226 1.131 0.579 1.725 0.839 2.026 0.092 0.7 0.35 1.48 0.569 1.944 0.159 0.339 0.234 0.801 0.234 1.454 0 0.607-0.023 0.614-0.159 0.657-1.767 0.522-4.579 1.538-5.628 1.997-1.725-2.042-2.768-4.679-2.768-7.555 0-6.467 5.261-11.729 11.729-11.729zM7.811 24.386c1.201-0.49 3.594-1.344 5.167-1.808 0.914-0.288 0.914-1.058 0.914-1.677 0-0.513-0.035-1.269-0.335-1.908-0.206-0.438-0.442-1.189-0.494-1.776-0.011-0.137-0.076-0.265-0.18-0.355-0.151-0.132-0.458-0.616-0.654-1.593-0.155-0.773-0.089-0.942-0.026-1.106 0.027-0.070 0.053-0.139 0.074-0.216 0.128-0.468-0.015-2.005-0.17-2.858-0.068-0.371 0.018-1.424 0.711-2.311 0.622-0.795 1.563-1.238 2.764-1.315l1.011-0.001c1.233 0.078 2.174 0.521 2.797 1.316 0.694 0.887 0.778 1.94 0.71 2.312-0.154 0.852-0.298 2.39-0.17 2.857 0.022 0.078 0.047 0.147 0.074 0.217 0.064 0.163 0.129 0.333-0.025 1.106-0.196 0.977-0.504 1.461-0.655 1.593-0.103 0.091-0.168 0.218-0.18 0.355-0.051 0.588-0.286 1.338-0.492 1.776-0.236 0.502-0.508 1.171-0.508 1.886 0 0.619 0 1.389 0.924 1.68 1.505 0.445 3.91 1.271 5.18 1.77-2.121 2.1-5.035 3.4-8.248 3.4-3.183 0-6.073-1.277-8.188-3.342z"" fill=""currentcolor""> </path> </g>
                    </svg>  
                ", w, h));
            };
        }

        public static RenderFragment CalendarIcon(int w, int h)
        {
            return (builder) =>
            {
                builder.AddMarkupContent(0, string.Format(@"
       	             <svg width=""{0}"" height=""{1}"" viewBox=""0 0 24 24"" fill=""none"">
                        <g id=""SVGRepo_bgCarrier"" stroke-width=""0""/>
                        <g id=""SVGRepo_tracerCarrier"" stroke-linecap=""round"" stroke-linejoin=""round""/>
                        <g id=""SVGRepo_iconCarrier""> <path d=""M2 12C2 8.22876 2 6.34315 3.17157 5.17157C4.34315 4 6.22876 4 10 4H14C17.7712 4 19.6569 4 20.8284 5.17157C22 6.34315 22 8.22876 22 12V14C22 17.7712 22 19.6569 20.8284 20.8284C19.6569 22 17.7712 22 14 22H10C6.22876 22 4.34315 22 3.17157 20.8284C2 19.6569 2 17.7712 2 14V12Z"" stroke=""currentcolor"" stroke-width=""1.5""/> <path opacity=""0.5"" d=""M7 4V2.5"" stroke=""currentcolor"" stroke-width=""1.5"" stroke-linecap=""round""/> <path opacity=""0.5"" d=""M17 4V2.5"" stroke=""currentcolor"" stroke-width=""1.5"" stroke-linecap=""round""/> <path opacity=""0.5"" d=""M2.5 9H21.5"" stroke=""currentcolor"" stroke-width=""1.5"" stroke-linecap=""round""/> <path d=""M18 17C18 17.5523 17.5523 18 17 18C16.4477 18 16 17.5523 16 17C16 16.4477 16.4477 16 17 16C17.5523 16 18 16.4477 18 17Z"" fill=""currentcolor""/> <path d=""M18 13C18 13.5523 17.5523 14 17 14C16.4477 14 16 13.5523 16 13C16 12.4477 16.4477 12 17 12C17.5523 12 18 12.4477 18 13Z"" fill=""currentcolor""/> <path d=""M13 17C13 17.5523 12.5523 18 12 18C11.4477 18 11 17.5523 11 17C11 16.4477 11.4477 16 12 16C12.5523 16 13 16.4477 13 17Z"" fill=""currentcolor""/> <path d=""M13 13C13 13.5523 12.5523 14 12 14C11.4477 14 11 13.5523 11 13C11 12.4477 11.4477 12 12 12C12.5523 12 13 12.4477 13 13Z"" fill=""currentcolor""/> <path d=""M8 17C8 17.5523 7.55228 18 7 18C6.44772 18 6 17.5523 6 17C6 16.4477 6.44772 16 7 16C7.55228 16 8 16.4477 8 17Z"" fill=""currentcolor""/> <path d=""M8 13C8 13.5523 7.55228 14 7 14C6.44772 14 6 13.5523 6 13C6 12.4477 6.44772 12 7 12C7.55228 12 8 12.4477 8 13Z"" fill=""currentcolor""/> </g>
                      </svg>
                ", w, h));
            };
        }



        #endregion
    }
}
