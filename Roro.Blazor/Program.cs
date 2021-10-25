import static com.google.android.gms.location.LocationServices.getFusedLocationProviderClient;

public class AmenitiesFragment extends Fragment {

    static ArrayList<Post> posts;
    Post p;
    RecyclerViewAdapter recyclerViewAdapter;
    static RecyclerView recyclerView;

    private LocationRequest mLocationRequest;
    LocationManager locationManager;
    static Location currentUserLocation;
    Location postLocation = null;

    static double distanceToLocation = 0;


    @Nullable
    @Override
    public View onCreateView(@NonNull LayoutInflater inflater, @Nullable ViewGroup container, @Nullable Bundle savedInstanceState) {
        final View rootView = inflater.inflate(R.layout.amenities_fragment_layout, null);

        locationManager = (LocationM…
