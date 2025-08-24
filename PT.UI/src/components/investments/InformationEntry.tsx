export default function InformationEntry({
  label,
  value,
}: {
  label: string;
  value: string;
}) {
  return (
    <div className='text-xl text-center font-medium dark:text-white'>
      <p>
        {label}: {value}
      </p>
    </div>
  );
}
