import type { JSX } from 'react';

export default function InvestedValueWidget({
  content,
}: {
  content: string | JSX.Element;
}) {
  return (
    <div className='flex flex-col mx-auto h-75 w-full max-w-sm justify-center rounded-xl p-6 gap-8 shadow-lg outline outline-black/5 dark:bg-slate-800 dark:shadow-none dark:-outline-offset-1 dark:outline-white/10'>
      <p className='text-xl text-center font-medium dark:text-white'>
        Invested Value
      </p>
      <div className='text-xl text-center font-medium dark:text-white overflow-x-auto'>
        <p>{content}</p>
      </div>
    </div>
  );
}
