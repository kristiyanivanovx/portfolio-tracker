import InformationEntry from './InformationEntry';

export default function InvestmentCard({
  title,
  name,
  type,
  value,
}: {
  title: string;
  name: string;
  type: string;
  value: string;
}) {
  return (
    <div className='flex flex-col mx-auto w-full max-w-sm justify-center rounded-xl p-6 gap-3 outline dark:bg-cyan-900 dark:-outline-offset-1 dark:outline-white/10'>
      <p className='text-xl text-center font-medium dark:text-white'>{title}</p>
      <InformationEntry label='Name' value={name} />
      <InformationEntry label='Type' value={type} />
      <InformationEntry label='Value' value={value} />
    </div>
  );
}
